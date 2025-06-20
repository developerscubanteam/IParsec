using Domain.Booking;
using Domain.Common;
using Domain.Common.MinimumPrice;
using Infrastructure.Connectivity.Connector.Models.Message.BookingRQ;
using Infrastructure.Connectivity.Connector.Models.Message.BookingRS;
using Infrastructure.Connectivity.Connector.Models.Message.Common;
using Infrastructure.Connectivity.Connector.Models.Message.ErrorRS;
using System.Globalization;
using System;
using BookingRoom = Infrastructure.Connectivity.Connector.Models.Message.BookingRS.BookingRoom;

namespace Application.WorkFlow.Services
{
    class BookingResponseService
    {
        public static Booking ToDto(Dictionary<string, List<string>>? include, Booking booking, (BookingRS? BookingRS, List<Domain.Error.Error>? Errors, AuditData AuditData) Response)
        {
            
            booking.AuditData = Response.AuditData;

            if (Response.Errors != null && Response.Errors.Any())
            {
                booking.Status= Status.Error;
                booking.Errors = Response.Errors;
                return booking;
            }

            AddBookingDetails(include, BookingsK.intance, booking, Response);

            return booking;
        }

        public static Bookings ToListDto(Dictionary<string, List<string>>? include, Bookings bookings, (BookingRS? BookingRS, List<Domain.Error.Error>? Errors, AuditData AuditData) Response)
        {
            
            bookings.AuditData = Response.AuditData;

            if (Response.Errors != null && Response.Errors.Any())
            {
                bookings.Errors = Response.Errors;
                return bookings;
            }

            var bookingList = new List<Booking>() { AddBookingDetails(include, BookingsK.intance, new Booking(), Response) };
            bookings.BookingList = bookingList;

            return bookings;
        }

        private static Booking AddBookingDetails(Dictionary<string, List<string>>? include, Parent keyInclude, Booking booking,
            (BookingRS? BookingRS, List<Domain.Error.Error>? Errors, AuditData AuditData) Response)
        {
            if (Response.BookingRS != null)
            {
                var hotelRes = Response.BookingRS.BookingInfoRs.HotelResList.First();
                var locator = hotelRes.HotelResInfo.HotelResIDs.FirstOrDefault(x => x.Type == "Locator").ID;
                var globalInfo = Response.BookingRS.BookingInfoRs.ResGlobalInfo;
                var bookingRoom = hotelRes.Rooms.FirstOrDefault();
                var currency = bookingRoom.RoomRate.Total.Currency;
                var checkin = DateTime.ParseExact(globalInfo.DateRange.Start, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                booking.Status = SetStatus(hotelRes);
                booking.BookingId = locator;

                if (IncludeService.CheckIfIsIncluded(include, keyInclude, BookingsK.Cancellocator.intance))
                    booking.CancelLocator = "";

                if (IncludeService.CheckIfIsIncluded(include, keyInclude, BookingsK.HotelConformationCode.intance))
                    booking.HCN = "";

                if (IncludeService.CheckIfIsIncluded(include, keyInclude, BookingsK.CheckInDate.intance))
                    booking.CheckIn = DateTime.ParseExact(globalInfo.DateRange.Start, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                if (IncludeService.CheckIfIsIncluded(include, keyInclude, BookingsK.CheckOutDate.intance))
                    booking.CheckOut = DateTime.ParseExact(globalInfo.DateRange.End, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                if (IncludeService.CheckIfIsIncluded(include, keyInclude, BookingsK.HotelConformationCode.intance))
                    booking.ClientReference = globalInfo.ResIDs.Where(x=>x.Type == "ClientReference").FirstOrDefault().ID;

                if (IncludeService.CheckIfIsIncluded(include, keyInclude, BookingsK.Comments.intance))
                    booking.Comments = GetComments( hotelRes);

                if (IncludeService.CheckIfIsIncluded(include, Holder.intance, Holder.Empty.intance))
                    booking.Holder = GetHolder(default, globalInfo);

                if (IncludeService.CheckIfIsIncluded(include, Hotel.intance, Hotel.Empty.intance))
                    booking.Hotel = GetHotelInfo(include, hotelRes);

                if (IncludeService.CheckIfIsIncluded(include, Mealplans.intance, Mealplans.Empty.intance))
                    booking.Mealplan = GetMealplanInfo(include, bookingRoom);

                if (IncludeService.CheckIfIsIncluded(include, Rooms.intance, Rooms.Empty.intance))
                    booking.Rooms = GetRooms(include, hotelRes);

                if (IncludeService.CheckIfIsIncluded(include, Prices.intance, Prices.Empty.intance))
                {
                    booking.Price = GetPrice(hotelRes);
                    booking.MinimumPrice = GetMinimumPrice(default);
                }

                if (IncludeService.CheckIfIsIncluded(include, Cancellationpolicy.intance, Cancellationpolicy.Empty.intance))
                   booking.CancellationPolicy = GetCancellationPolicy(include, hotelRes.Rooms, currency, checkin);

                if (IncludeService.CheckIfIsIncluded(include, Fees.intance, Fees.Empty.intance))
                    booking.Fees = GetFees(default);
            }

            return booking;
        }

        private static BookingHotel GetHotelInfo(Dictionary<string, List<string>>? include,
            Infrastructure.Connectivity.Connector.Models.Message.BookingRS.HotelRes hotelRes)
        {
            //TODO: Fill hotel
            var hotelInfo = hotelRes.Info;
            var hotel = new BookingHotel()
            {
                Code = hotelInfo.HotelCode,
            };

            if (IncludeService.CheckIfIsIncluded(include, Hotel.intance, Hotel.Name.intance))
                hotel.Name = hotelInfo.HotelName;

            return hotel;
        }

        private static Mealplan GetMealplanInfo(Dictionary<string, List<string>>? include,
            BookingRoom room)
        {
            // TODO: Fill mealplan
            var mealplan = new Mealplan()
            {
                Code = room.RoomRate.MealPlan,

            };

            if (IncludeService.CheckIfIsIncluded(include, Mealplans.intance, Mealplans.Name.intance))
                mealplan.Name = room.RoomRate.MealPlan;

            return mealplan;
        }
        private static List<Fee>? GetFees(object service)
        {
            // TODO: Fill fees
            return null;
        }

        private static Domain.Common.Price.Price GetPrice(
            Infrastructure.Connectivity.Connector.Models.Message.BookingRS.HotelRes hotelRes
            )
        {
            // TODO: Fill price
            var roomRates = hotelRes.Rooms.Select(r=>r.RoomRate).ToList();

            if (roomRates.Any())
            {
                var currency = roomRates.FirstOrDefault().Total.Currency;
                decimal totalCommission = 0;
                decimal totalAmount = 0;

                foreach (var roomRate in roomRates)
                {
                    totalAmount += roomRate.Total.Amount;
                    totalCommission += roomRate.Total.Commission;
                }

                return PriceService.GetPrice(currency, totalAmount, true, totalCommission, null);
            }

            return null;
        }

        private static MinimumPrice? GetMinimumPrice(List<object> prices)
        {
            // TODO: Fill minimum price
            //GetMinimumPrice(default,default)
            return null;
        }

        private static MinimumPrice? GetMinimumPrice(decimal? totalSellingPrice, string currency)
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

        private static Domain.Common.Pax? GetHolder(Dictionary<string, List<string>>? include,
            Infrastructure.Connectivity.Connector.Models.Message.BookingRS.ResGlobalInfo globalInfo)
        {
            // TODO: Fill holder
           
            return null;
        }

        private static Domain.Common.Pax GetPax(Dictionary<string, List<string>>? include, Parent key, 
            Guest pax)
        {
            // TODO: Fill pax
            var personInfo = pax.PersonName;
            var bkPax = new Domain.Common.Pax()
            {
                Name = personInfo.GivenName,
                Surname = personInfo.Surname
            };

            if (IncludeService.CheckIfIsIncluded(include, key, Paxes.Title.intance))
                bkPax.Title = personInfo.NamePrefix;

            if (IncludeService.CheckIfIsIncluded(include, key, Paxes.Address.intance))
                bkPax.Address = default;

            if (IncludeService.CheckIfIsIncluded(include, key, Paxes.Country.intance))
                bkPax.Country = default;

            if (IncludeService.CheckIfIsIncluded(include, key, Paxes.City.intance))
                bkPax.City = default;

            if (IncludeService.CheckIfIsIncluded(include, key, Paxes.Age.intance))
                bkPax.Age = default;

            if (IncludeService.CheckIfIsIncluded(include, key, Paxes.Document.intance))
                bkPax.Document = null;

            if (IncludeService.CheckIfIsIncluded(include, key, Paxes.Email.intance))
                bkPax.Email = default;

            if (IncludeService.CheckIfIsIncluded(include, key, Paxes.Idpax.intance))
                bkPax.Id = default;

            if (IncludeService.CheckIfIsIncluded(include, key, Paxes.Phonenumber.intance))
                bkPax.PhoneNumber = default;

            if (IncludeService.CheckIfIsIncluded(include, key, Paxes.Postalcode.intance))
                bkPax.PostalCode = default;

            return bkPax;
        }

        private static List<Domain.Booking.BookingRoom>? GetRooms(Dictionary<string, List<string>>? include, Infrastructure.Connectivity.Connector.Models.Message.BookingRS.HotelRes hotelRes)
        {
            // TODO: Fill rooms

            var rooms = new List<Domain.Booking.BookingRoom>();
            foreach (var room in hotelRes.Rooms)
            {               
                var occupancy = new List<Domain.Common.Pax>();
                foreach (var relpax in room.Guests)
                {
                    occupancy.Add(GetPax(include, Paxes.intance, relpax));
                }

                var bookingRoom = new Domain.Booking.BookingRoom() { Code = room.RoomType.Code };

                if (IncludeService.CheckIfIsIncluded(include, Rooms.intance, Rooms.Name.intance))
                    bookingRoom.Name = room.RoomType.Name;

                if (IncludeService.CheckIfIsIncluded(include, Rooms.intance, Rooms.Description.intance))
                    bookingRoom.Description = room.RoomType.Name;

                if (IncludeService.CheckIfIsIncluded(include, Paxes.intance, Paxes.Empty.intance))
                    bookingRoom.Paxes = occupancy;

                rooms.Add(bookingRoom);
            }
            return rooms;

        }

        private static string GetComments(Infrastructure.Connectivity.Connector.Models.Message.BookingRS.HotelRes hotelRes) {

            // TODO: Fill comments
            string result = "";
            var room = hotelRes.Rooms.First();

            if (room.RoomType != null)
            {
                if (room.RoomType.ExtraInfo != null && room.RoomType.ExtraInfo.Any())
                    result = string.Join(".", room.RoomType.ExtraInfo.Select(x => x.Text));

                if (room.RoomType.Special != null)
                    result += "." + room.RoomType.Special;

                if (hotelRes.Info != null && hotelRes.Info.Warnings != null && hotelRes.Info.Warnings.Any())
                    result += "." + string.Join(".", hotelRes.Info.Warnings.Select(x => x.Text));
            }

            return result;
        }

        private static Domain.Common.CancellationPolicy.CancellationPolicy? GetCancellationPolicy(Dictionary<string, List<string>>? include,
            List<BookingRoom> rooms, string currency, DateTime checking)
        {
            if (IncludeService.CheckIfIsIncluded(include, Cancellationpolicy.intance, Cancellationpolicy.Empty.intance))
            {
                // TODO: Fill CancellationPolicy
                var listCancellationPolicies = new List<Tuple<int, DateTime, decimal>>();
                int roomRef = 1;
                foreach (var room in rooms)
                {
                    var roomRate = room.RoomRate;                   
                    var penaltyObj = roomRate.CancelPenalties;
                    var cancelPenalties = penaltyObj.CancelPenalty;
                    foreach (var penalty in cancelPenalties)
                    {
                        var amount = penalty.Charge.Amount == null ? 0 : penalty.Charge.Amount;
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
                    roomRef++;
                }
                if (listCancellationPolicies.Any())
                {
                    return Infrastructure.Connectivity.Connector.Extension.Extension
                        .ProcessCancelPolice(listCancellationPolicies, currency, rooms.Count);
                }
            }
            return null;
        }

        private static Status SetStatus(
            Infrastructure.Connectivity.Connector.Models.Message.BookingRS.HotelRes hotelRes)
        {
           var status = hotelRes.ResStatus;
           switch (status)
            {
                case "OK":
                    return Status.Confirmed;
                case "CA":
                    return Status.Cancelled;
                case "OR":
                    return Status.OnRequest;
                default:
                    return Status.Error; 
            }
        }

    }
}
