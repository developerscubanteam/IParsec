using Application.Dto.AvailabilityService;
using Application.WorkFlow.Contracts;
using Infrastructure.Connectivity.Contracts;
using Infrastructure.Connectivity.Queries;
using Infrastructure.Connectivity.Queries.Base;
using AvailabilityRS = Infrastructure.Connectivity.Connector.Models.Message.AvailabilityRS.AvailabilityRS;
using Infrastructure.Connectivity.Connector.Models.Message.AvailabilityRS;
using Application.WorkFlow.Services;
using Domain.Common.MinimumPrice;
using Infrastructure.Connectivity.Connector.Models.Message.Common;
using System.Text;
using Domain.Availability;
using Domain.Common;
using Infrastructure.Connectivity.Connector.Models;
using CultureInfo = System.Globalization.CultureInfo;
using Infrastructure.Connectivity.Connector.Models.Message.BookingRQ;
using RoomRate = Infrastructure.Connectivity.Connector.Models.Message.Common.RoomRate;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Room = Infrastructure.Connectivity.Connector.Models.Message.AvailabilityRS.Room;
using Domain.ValuationCode;

namespace Application.WorkFlow
{
    public class AvailabilityService : IAvailabilityService
    {
        private readonly IConnector _connector;

        public AvailabilityService(
            IConnector connector)
        {
            _connector = connector;
        }

        public class GroupedByMealplan
        {
            public string? Name { get; set; }
            public required List<Combination> Combinations { get; set; }
        }

        public async Task<Availability> GetAvailability(AvailabilityQuery query)
        {
            var availabilities = await _connector.Availability(ConvertToConnectoryQuery(query));
            return ToDto(query, availabilities);            
        }

        private AvailabilityConnectorQuery ConvertToConnectoryQuery(AvailabilityQuery query)
        {
            var connection = query.ExternalSupplier.GetConnection();
            var rooms = new Infrastructure.Connectivity.Queries.Room[query.SearchCriteria.RoomCandidates.Count];
            var index = 0;

            foreach (var room in query.SearchCriteria.RoomCandidates)
            {
                rooms[index] = new Infrastructure.Connectivity.Queries.Room()
                {
                    RoomRefId = room.RoomRefId,
                    Pax = room.PaxesAge.Select(x => new Infrastructure.Connectivity.Queries.Base.Pax() { Age = x }).ToList()
                };
                index++;
            }

            var searchCriteria = new Infrastructure.Connectivity.Queries.SearchCriteria
            {
                CheckInDate = query.SearchCriteria.CheckIn,
                CheckOutDate = query.SearchCriteria.CheckOut,
                Currency = query.SearchCriteria.Currency,
                Nationality = query.SearchCriteria.Nationality,
                Market = query.SearchCriteria.Market,
                RoomCandidates = rooms,
                Accommodations = query.SearchCriteria.AccommodationCodes.ToList(),
                Language = query.SearchCriteria.Language,
                OnRequest = query.SearchCriteria.OnRequest
            };


            var connectorQuery = new AvailabilityConnectorQuery()
            {
                SearchCriteria = searchCriteria,
                ConnectionData = new ConnectionData()
                {
                    Url = connection.Url,
                    Username = connection.Username,
                    Password = connection.Password,
                    Context = connection.Context
                },
                AdvancedOptions = new AvConnectorAdvancedOptions()
                {
                    ShowBreakdownPrice = GetShowPriceBreakDown(query.Include),
                    ShowCancellationPolicies = GetShowCancellationPolicies(query.Include),
                    ShowHotelInfo = GetShowHotelInfo(query.Include)
                }
            };
            connectorQuery.AuditRequests = query.AuditRequests;
            connectorQuery.Timeout = query.Timeout;
            return connectorQuery;
        }

        private Availability ToDto(AvailabilityQuery query, (AvailabilityRS? AvailabilityRs, List<Domain.Error.Error>? Errors, AuditData AuditData) Availabilities)
        {
            var availability = new Availability();
            availability.AuditData = Availabilities.AuditData;

            if (Availabilities.Errors != null && Availabilities.Errors.Any())
                availability.Errors = Availabilities.Errors;            
            else            
                availability.Accommodations = WithResults(query, Availabilities.AvailabilityRs);

            return availability;            
        }

        private List<Accommodation> WithResults(AvailabilityQuery query, AvailabilityRS? AvailabilityRs)
        {
            var vc = new StringBuilder();

            var accommodations = new List<Accommodation>();
            var roomCandidates = query.SearchCriteria.RoomCandidates;
            var roomsRef = query.SearchCriteria.RoomCandidates.Select(i => i.RoomRefId).ToArray();

            if (AvailabilityRs != null)
            {
                var hotelList = AvailabilityRs.Hotels.Hotel;

                foreach (var hotel in hotelList)
                {
                    var rooms = hotel.Rooms;
                    var establishmentId = hotel.Info.HotelCode.ToString();                  

                    var mealPlan = new Dictionary<string, GroupedByMealplan>();

                    foreach (var room in rooms)
                    {
                        var roomRates = room.RoomRates;
                        foreach (var roomRate in roomRates)
                        {                           
                            var combination = new Combination();
                            combination.PaymentType = PaymentType.SupplierPayment;
                            combination.Status = room.Status == "AV" ? StatusAvailability.Available : StatusAvailability.OnRequest;
                            combination.NonRefundable = IsNotRefundable(roomRate);
                            combination.Rooms = GetRooms(query.Include, room);
                            combination.Fees = GetFees(query.Include, default);
                            combination.MinimumPrice = GetMinimumPrice(roomRate);
                            combination.Price = GetPrice(roomRate/*, roomCandidates.Count*/);                            
                            combination.CancellationPolicy = GetCancellationPolicy(query.Include, roomRate.CancelPenalties, query.SearchCriteria.CheckIn, query.SearchCriteria.Currency/*, roomCandidates.Count*/);
                            combination.RateConditions = GetRateConditions(query.Include, roomRate);
                            combination.AdditionalServices = [];
                            combination.Remarks = GetRemarks(room, hotel.Info.Warnings);
                            combination.ValuationCode = GetValuationCode(vc, establishmentId, roomRate.BookingCode, int.Parse(room.RPH), query.SearchCriteria);
                            //combination.Promotions = GetPromotions(query.Include, hotelOption.AdditionalElements.HotelOffers);
                            AddMealplan(mealPlan, combination, roomRate.MealPlan, query);
                       }
                    }
                    var hotelCode = hotel.Info.HotelCode;
                    var accommodation = GetAccommodation(query.Include, hotelCode, null, mealPlan, query);
                    if (accommodation.Mealplans != null && accommodation.Mealplans.Any())
                        accommodations.Add(accommodation);
                }
            }
            return accommodations;
            
        }

        private IList<RateConditionType>? GetRateConditions(Dictionary<string, List<string>>? include, RoomRate rate)
        {
            if (IncludeService.CheckIfIsIncluded(include, RateConditions.intance, RateConditions.Empty.intance))
            {
                List<RateConditionType> result = new List<RateConditionType>();
                if (rate.CancelPenalties != null && rate.CancelPenalties.NonRefundable)
                {
                    result.Add(RateConditionType.NonRefundable);
                }

                return result;
            };

            return null;
        }

        private Accommodation GetAccommodation(Dictionary<string, List<string>>? include, string code, string? name, Dictionary<string, GroupedByMealplan> mealPlan, AvailabilityQuery query)
        {
            var accommodation = new Accommodation() { 
              Code = code,
              Mealplans = []
            };           

            if (IncludeService.CheckIfIsIncluded(include, Accommodations.intance, Accommodations.Name.intance))
                accommodation.Name = name;
            
            var notCombined = GetMealplans(include, mealPlan);

            foreach (var item in notCombined)
            {
                if (IsThereAllRoomsRefIdPresent(item, query))
                {
                    var mealPlanCombinado = new Domain.Availability.Mealplan()
                    {
                        Code = item.Code,
                        Name = item.Name,
                        Combinations = CombinationService.BuildCombinations(item, query, SumCustomValCode).Combinations
                    };
                    
                    if (mealPlanCombinado.Combinations != null && mealPlanCombinado.Combinations.Any())
                        accommodation.Mealplans.Add(mealPlanCombinado);
                }
            }

            return accommodation;
        }

        public bool IsThereAllRoomsRefIdPresent(Domain.Availability.Mealplan mealPlan, AvailabilityQuery query)
        {
            var roomRefIdList = query.SearchCriteria.RoomCandidates.Select(r => r.RoomRefId).ToHashSet();
            bool result = roomRefIdList.All(x => mealPlan.Combinations.Any(c => c.Rooms.First().RoomRefId == x));

            return result;
        }

        private string SumCustomValCode(IEnumerable<Combination> data)
        {
            var consiladedValuationCode = "";
            for (int i = 0; i < data.Count(); i++)
            {

                if (i != 0)
                    consiladedValuationCode = FlowCodeServices.SumValuationCodes(consiladedValuationCode, data.ElementAt(i).ValuationCode);
                else
                    consiladedValuationCode = data.ElementAt(i).ValuationCode;
            }
            return consiladedValuationCode;

        }


        private PaymentType GetPaymentType(string? paymentType)
        {
            if (paymentType == null)
                return PaymentType.SupplierPayment;

            if (paymentType!=null && paymentType == "")
                return PaymentType.PaymentAtDestination;

            return PaymentType.SupplierPayment;
        }

        private bool IsNotRefundable(RoomRate roomRate)
        {            
            return roomRate.CancelPenalties.NonRefundable;
        }


        private string GetValuationCode(StringBuilder vc, string establishmentId, string bookingCode, int roomsRef, Dto.AvailabilityService.SearchCriteria searchCriteria)
        {
            var checkIn = searchCriteria.CheckIn.ToFormat_yyyyMMdd();
            return FlowCodeServices.GetValuationCode(vc, establishmentId, bookingCode, roomsRef, checkIn);
        }

      

        private List<Domain.Common.Fee>? GetFees(Dictionary<string, List<string>>? include, object hotelOption)
        {
            if (IncludeService.CheckIfIsIncluded(include, Fees.intance, Fees.Empty.intance))
            {                
                var fees = new List<Domain.Common.Fee>();                

                if (fees.Any())
                    return fees;
            }

            return null;
        }

        private Domain.Common.Price.Price GetPrice(RoomRate roomRate/*, int roomCandidatesCount*/)
        {
            var price = PriceService.GetPrice(
                roomRate.Total.Currency,
                (decimal)roomRate.Total.Amount /* * roomCandidatesCount*/,
                false,
                (decimal)roomRate.Total.Commission/* * roomCandidatesCount*/,
                null
             );
          
            return price;
        }

        private MinimumPrice? GetMinimumPrice(RoomRate roomRate)
        {
            return roomRate.Total.MinPrice != 0 ? new MinimumPrice()
            {
                Purchase = new Domain.Common.MinimumPrice.Purchase() { Amount = (decimal)roomRate.Total.MinPrice, Currency = roomRate.Total.Currency }
            } : null;
        }

        private IList<Domain.Common.Room>? GetRooms(Dictionary<string, List<string>>? include, Room data)
        {
            List<Domain.Common.Room> rooms = new List<Domain.Common.Room>();
            
            Domain.Common.Room room = new Domain.Common.Room()
            {
                Code = data.RoomType.Code,
                Description = data.RoomType.Name,
                RoomRefId = int.Parse(data.RPH)
            };
            
            rooms.Add(room);            
            return rooms;
        }

        private Domain.Common.RoomOccupancy? GetRoomOccupancy(object room)
        {
            if (room != null)
            {
                return new Domain.Common.RoomOccupancy()
                {
                    Adults = 1,
                    Children = 1,
                    AvailableRooms = 1,                   
                };
            }
            else
                return null;
        }

        private Domain.Common.CancellationPolicy.CancellationPolicy? GetCancellationPolicy(Dictionary<string, List<string>>? include,
            CancelPenalties cancellationPolicy, DateTime checkIn, string currency/*, int roomCandidatesCount*/)
        {
            if (IncludeService.CheckIfIsIncluded(include, Cancellationpolicy.intance, Cancellationpolicy.Empty.intance))
            {
                if (cancellationPolicy != null)
                    return Services.CancellationPolicyService.GetCancellationPolicy(cancellationPolicy, checkIn, currency);
            }
            return null;
        }

       


        private IList<Domain.Availability.Mealplan> GetMealplans(Dictionary<string, List<string>>? include, 
            Dictionary<string, GroupedByMealplan> mealPlans)
        {
            var accommodationsMealplan = new List<Domain.Availability.Mealplan>();
            foreach (var mealplanKey in mealPlans.Keys)
            {
                var mealplan = new Domain.Availability.Mealplan();
                mealplan.Code = mealplanKey;
                mealplan.Combinations = mealPlans[mealplanKey].Combinations;

                if (IncludeService.CheckIfIsIncluded(include, Mealplans.intance, Mealplans.Name.intance))
                    mealplan.Name = mealPlans[mealplanKey].Name;

                accommodationsMealplan.Add(mealplan);
            }

            return accommodationsMealplan;
        }

        private void AddMealplan(Dictionary<string, GroupedByMealplan> mealplans, Combination combination, string board, AvailabilityQuery query)
        {
            if (IsAValidCombination(combination, query))
            {
                if (mealplans.ContainsKey(board))
                    mealplans[board].Combinations.Add(combination);
                else
                {
                    var groupedByMealplan = new GroupedByMealplan() { Name = board, Combinations = new List<Combination>() };
                    groupedByMealplan.Combinations.Add(combination);
                    mealplans.Add(board, groupedByMealplan);
                }
            }
        }

        private List<string> GetRemarks(Room room, List<Msg> hotelWarningsField)
        {
            var result = new List<string>();

            if (hotelWarningsField != null && hotelWarningsField.Any())
                result.AddRange(hotelWarningsField.Select(x => x.Text));

            if (room.RoomType.ExtraInfo != null && room.RoomType.ExtraInfo.Any())
                result.AddRange(room.RoomType.ExtraInfo.Select(x => x.Text));

            if (!string.IsNullOrWhiteSpace(room.RoomType.Special))
                result.Add(room.RoomType.Special);

            if (result.Count != 0)
                return result;
            else
                return null;
        }
        private bool IsAValidCombination(Combination combination, AvailabilityQuery query)
        {
            /*if ((combination.Rooms == null || !combination.Rooms.Any()) || query.SearchCriteria.RoomCandidates.Count() != combination.Rooms.Count())
                return false;
            */
            if (combination.Price == null || !combination.Rooms.Any())
                return false;

            return true;

        }

        private bool GetShowHotelInfo(Dictionary<string, List<string>>? include)
        {
            return IncludeService.CheckIfIsIncluded(include, Accommodations.intance, Accommodations.Empty.intance) ||
                   IncludeService.CheckIfIsIncluded(include, Accommodations.intance, Accommodations.Name.intance);
        }

        private bool GetShowCancellationPolicies(Dictionary<string, List<string>>? include)
        {
            return IncludeService.CheckIfIsIncluded(include, new Cancellationpolicy(), new Cancellationpolicy.Empty());
        }

        private bool GetShowPriceBreakDown(Dictionary<string, List<string>>? include)
        {
            return IncludeService.CheckIfIsIncluded(include, new Fees(), new Fees.Empty());
        }


    }
}
