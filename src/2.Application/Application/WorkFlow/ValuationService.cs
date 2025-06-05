#nullable disable

using Application.Dto.ValuationService;
using Application.WorkFlow.Contracts;
using Application.WorkFlow.Services;
using Domain.Common;
using Domain.Common.MinimumPrice;
using Domain.Error;
using Domain.Valuation;
using Domain.ValuationCode;
using Infrastructure.Connectivity.Connector.Models.Message.BookingRQ;
using Infrastructure.Connectivity.Connector.Models.Message.Common;
using Infrastructure.Connectivity.Connector.Models.Message.ValuationRQ;
using Infrastructure.Connectivity.Connector.Models.Message.ValuationRS;
using Infrastructure.Connectivity.Contracts;
using Infrastructure.Connectivity.Queries;
using Infrastructure.Connectivity.Queries.Base;
using System.Data;
using System.Globalization;
using Room = Infrastructure.Connectivity.Connector.Models.Message.ValuationRS.Room;
using RoomRate = Infrastructure.Connectivity.Connector.Models.Message.Common.RoomRate;

namespace Application.WorkFlow
{
    public class ValuationService : IValuationService
    {
        private readonly IConnector _connector;

        public ValuationService(IConnector connector)
        {
            _connector = connector;
        }

        public async Task<Valuation> GetValuation(ValuationQuery query)
        {
            var valuation = await CallConnector(query);
            return valuation;
        }

        private async Task<Valuation> CallConnector(ValuationQuery query)
        {
            var valuation = new Valuation();
            try
            {
                var valuationCode = FlowCodeServices.DecodeValuationCode(query.ValuationCode);

                var valuationRs = await _connector.Valuation(ConvertToConnectoryQuery(query, valuationCode));

                valuation = ToDto(valuationRs, valuationCode, query);

                return valuation;
            }
            catch (Exception ex)
            {
                var error = new Domain.Error.Error("UncontrolledException", ex.GetFullMessage(), Domain.Error.ErrorType.Error, Domain.Error.CategoryErrorType.Provider);
                valuation.Errors = new List<Domain.Error.Error> { error };
            };
            return valuation;

        }

        private ValuationConnectorQuery ConvertToConnectoryQuery(ValuationQuery query, ValuationCode vc)
        {
            var connection = query.ExternalSupplier.GetConnection();
            var connectionData = new ConnectionData()
            {
                Url = connection.Url,
                Username = connection.Username,
                Password = connection.Password,
                Context = connection.Context
            };

            var connectorQuery = new ValuationConnectorQuery()
            {
                AdvancedOptions = new VAConnectorAdvancedOptions()
                {
                    ShowBreakdownPrice = GetShowPriceBreakDown(query.Include)
                },
                ConnectionData = connectionData,
                ValuationCode = vc,
                Timeout = query.Timeout
            };

            return connectorQuery;
        }
        private bool GetShowPriceBreakDown(Dictionary<string, List<string>>? include)
        {
            return IncludeService.CheckIfIsIncluded(include, Fees.intance, Fees.Empty.intance);
        }

        private Valuation ToDto((ValuationRS? HotelBookingRulesRS, List<Domain.Error.Error>? Errors, AuditData AuditData) valuationRS, ValuationCode vc, ValuationQuery query)
        {
            var result = new Valuation();
            result.AuditData = valuationRS.AuditData;

            if (valuationRS.Errors != null && valuationRS.Errors.Any())
                result.Errors = valuationRS.Errors;
       
            if (valuationRS.HotelBookingRulesRS != null)
            {
                //TODO: Fill Valuation
                var hotelOption = valuationRS.HotelBookingRulesRS.results;
                //var roomRateList = hotelOption.Rooms;
                var roomRateList = hotelOption.Rooms.Where(r => r.RoomRates != null).SelectMany(r => r.RoomRates).ToList();
                var roomRate = roomRateList.FirstOrDefault();
                var currency = roomRate.Total.Currency;
                var checking = DateTime.ParseExact(vc.Checking, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                result.Status = GetStatus(result);
                result.Code = GetHotelCode(query.Include, default);
                result.Name = GetHotelName(query.Include, default);
                result.Mealplan = GetMealplan(query.Include, roomRate);
                result.Price = GetPrice(query.Include, roomRateList);
                result.CancellationPolicy = GetCancellationPolicy(query.Include, hotelOption.Rooms, currency, checking);
                result.MinimumPrice = GetMinimumPrice(query.Include, default);
                result.Fees = GetValuationFees(query.Include, default);
                result.Remarks = GetRemarks(query.Include, valuationRS.HotelBookingRulesRS);
                result.Promotions = GetPromotions(query.Include, default);
                result.Rooms = GetRooms(query.Include, valuationRS.HotelBookingRulesRS, vc);
                result.BookingCode = GetBookingCode(query.ValuationCode);
                result.PaymentType = GetPaymentType(query.Include, default);
                
            }

            return result;
        }
        private string? GetHotelCode(Dictionary<string, List<string>>? include, string? hotelCode)
        {
            if (IncludeService.CheckIfIsIncluded(include, Root.intance, Root.Code.intance))
                return hotelCode;

            return null;
        }
        private string? GetHotelName(Dictionary<string, List<string>>? include, string? name)
        {
            if (IncludeService.CheckIfIsIncluded(include, Root.intance, Root.Name.intance))
                return name;

            return null;
        }

        private StatusValuation GetStatus(object hotelOption)
        {
            //TODO: Fill Status
            // return hotelOption.Status == null || hotelOption.Status == "OK" ? StatusValuation.Available : StatusValuation.OnRequest;
            return StatusValuation.Available;
        }

        private Domain.Common.CancellationPolicy.CancellationPolicy? GetCancellationPolicy(Dictionary<string, List<string>>? include,
            List<Room> rooms, string currency, DateTime checking)
        {
            if (IncludeService.CheckIfIsIncluded(include, Cancellationpolicy.intance, Cancellationpolicy.Empty.intance))
            {
                // TODO: Fill CancellationPolicy
                var listCancellationPolicies = new List<Tuple<int, DateTime, decimal>>();
                foreach (var room in rooms)
                {
                    var roomRef = int.Parse(room.RPH);
                    var roomRateList = room.RoomRates;

                    foreach (var roomRate in roomRateList)
                    {
                        var penaltyObj = roomRate.CancelPenalties;
                        var cancelPenalties = penaltyObj.CancelPenalty;
                        foreach (var penalty in cancelPenalties)
                        {
                            var amount = penalty.Charge.Amount == null ? 0 : (decimal)penalty.Charge.Amount;
                            if (amount > 0)
                            {
                                var dateFrom = checking.AddDays(-penalty.Deadline.Units);
                                listCancellationPolicies.Add(new Tuple<int, DateTime, decimal>
                                    (
                                    roomRef,
                                    dateFrom,
                                    penalty.Charge.Amount
                                    ));
                            }
                        }
                    }
                    if (listCancellationPolicies.Any())
                    {
                        return Infrastructure.Connectivity.Connector.Extension.Extension
                            .ProcessCancelPolice(listCancellationPolicies, currency, rooms.Count);
                    }
                }
            }         
            return null;
        }

        private List<Promotion>? GetPromotions(Dictionary<string, List<string>>? include, object hotelOption)
        {
            if (IncludeService.CheckIfIsIncluded(include, Promotions.intance, Promotions.Empty.intance))
            {
                if (hotelOption != null)
                {
                    var promotions = new List<Promotion>();
                    // TODO: Fill Promotions
                    return promotions;
                }
            }
            return null;
        }

        private PaymentType? GetPaymentType(Dictionary<string, List<string>>? include, object hotelOption)
        {
            if (IncludeService.CheckIfIsIncluded(include, Root.intance, Root.Paymenttype.intance))
            {
                // TODO: Fill PaymentType
                //if (hotelOption.PaymentDestination == true)
                //    return PaymentType.PaymentAtDestination;

                //if (hotelOption.VirtualCreditCardInfo != null)
                //    if (DateTime.Parse(checkIn).Date == DateTime.Parse(hotelOption.VirtualCreditCardInfo.ValidFrom).Date)
                //        return PaymentType.CardCheckIn;
                //    else
                //        return PaymentType.CardBooking;
                //else
                return PaymentType.SupplierPayment;
            }
            return null;
        }

        private string GetBookingCode(string vc)
        {
            //TODO: Fill BookingCode

            return FlowCodeServices.GetBookingCode(vc);
        }

        private IEnumerable<Domain.Common.Room>? GetRooms(Dictionary<string, List<string>>? include, ValuationRS valuationConnectorRS, ValuationCode vc)
        {
            // TODO: Fill Rooms
            if (IncludeService.CheckIfIsIncluded(include, Rooms.intance, Rooms.Empty.intance))
            {
                var rooms = new List<Domain.Common.Room>();
                foreach (var supplierRoom in valuationConnectorRS.results.Rooms)
                {
                    int i = 0;

                    var room = new Domain.Common.Room()
                    {
                        RoomRefId = vc.RoomsRef[i],
                        Description = supplierRoom.RoomType.Name,
                        Code = supplierRoom.RoomType.Code,
                    };


                    if (IncludeService.CheckIfIsIncluded(include, Rooms.intance, Rooms.Name.intance))
                        room.Name = "";

                    if (IncludeService.CheckIfIsIncluded(include, Occupancy.intance, Occupancy.Empty.intance))
                        //room.Occupancy = GetRoomOccupancy(hotelRooms);

                    if (IncludeService.CheckIfIsIncluded(include, Rooms.intance, Rooms.Description.intance))
                        room.Description = "hotelRoom.Description";

                    i++;
                    rooms.Add(room);
                    return rooms;
                }               
            }

            return null;
        }

        private List<string>? GetRemarks(Dictionary<string, List<string>>? include, ValuationRS valuationConnectorRS)
        {
            if (IncludeService.CheckIfIsIncluded(include, Root.intance, Root.Remarks.intance))
            {
                var roomType = valuationConnectorRS.results.Rooms.First().RoomType;

                List<string> remarks = new List<string>();
                if (roomType.ExtraInfo != null && roomType.ExtraInfo.Any())
                {
                    remarks.AddRange(roomType.ExtraInfo.Select(x => x.Text).ToList());
                }

                if (roomType.Special != null)
                {
                    remarks.Add(roomType.Special);
                }

                return remarks;

            }
            return null;
        }

        private Domain.Common.RoomOccupancy? GetRoomOccupancy(object? room)
        {
            if (room != null)
            {
                return new Domain.Common.RoomOccupancy()
                {
                    // TODO: Fill RoomOccupancy
                };
            }
            else
                return null;
        }
        private Domain.Common.Mealplan? GetMealplan(Dictionary<string, List<string>>? include, RoomRate roomRate)
        {
            // TODO: Fill Mealplan
            if (IncludeService.CheckIfIsIncluded(include, Mealplans.intance, Mealplans.Empty.intance))
            {
                if (roomRate != null)
                {
                    var mealplan = new Domain.Common.Mealplan()
                    {
                        Code = roomRate.MealPlan
                    };

                    if (IncludeService.CheckIfIsIncluded(include, Mealplans.intance, Mealplans.Name.intance))
                        mealplan.Name = roomRate.MealPlan;

                    return mealplan;
                }
            }

            return null;
        }

        private Domain.Common.Price.Price? GetPrice(Dictionary<string, List<string>>? include, List<RoomRate> roomRates)
        {
            if (IncludeService.CheckIfIsIncluded(include, Prices.intance, Prices.Empty.intance))
            {
                // TODO: Fill Price
                if (roomRates.Any())
                {
                    var currency = roomRates.FirstOrDefault().Total.Currency;
                    decimal totalCommission = 0;
                    decimal totalAmount = 0;

                    foreach ( var roomRate in roomRates)
                    {
                        totalAmount += roomRate.Total.Amount;
                        totalCommission += roomRate.Total.Commission;
                    }

                    return PriceService.GetPrice(currency, totalAmount, true, totalCommission, null);
                }           
            }

            return null;
        }

        private MinimumPrice? GetMinimumPrice(Dictionary<string, List<string>>? include, object hotelOption)
        {
            // TODO: Fill MinimumPrice
            if (IncludeService.CheckIfIsIncluded(include, Prices.intance, Prices.Empty.intance))
            {
                
                return GetMinimumPrice(0, "");

            }

            return null;
        }

        private MinimumPrice? GetMinimumPrice(decimal? totalSellingPrice, string currency)
        {
            if (totalSellingPrice.HasValue)
            {
                var minimumPrice = new Domain.Common.MinimumPrice.MinimumPrice()
                {
                    Purchase = new Domain.Common.MinimumPrice.Purchase()
                    {
                        Amount = totalSellingPrice.Value,
                        Currency = currency
                    }
                };
                return minimumPrice;
            }
            return null;
        }

        private IEnumerable<Fee>? GetValuationFees(Dictionary<string, List<string>>? include, object hotelOption)
        {
            if (IncludeService.CheckIfIsIncluded(include, Fees.intance, Fees.Empty.intance))
            {
               
                var fees = new List<Fee>();
                // TODO: Fill Fees

                if (fees.Any())
                    return fees;
            }
            return null;
        }
    }
}
