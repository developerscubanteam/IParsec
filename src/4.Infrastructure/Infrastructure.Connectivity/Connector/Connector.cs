using Domain.BookingCode;
using Domain.Common;
using Domain.ValuationCode;
using Infrastructure.Connectivity.Connector.Models;
using Infrastructure.Connectivity.Connector.Models.Message.AvailabilityRQ;
using Infrastructure.Connectivity.Connector.Models.Message.AvailabilityRS;
using Infrastructure.Connectivity.Connector.Models.Message.BookingRQ;
using Infrastructure.Connectivity.Connector.Models.Message.BookingRS;
using Infrastructure.Connectivity.Connector.Models.Message.Common;
using Infrastructure.Connectivity.Connector.Models.Message.ValuationRQ;
using Infrastructure.Connectivity.Connector.Models.Message.ValuationRS;
using Infrastructure.Connectivity.Contracts;
using Infrastructure.Connectivity.Queries;
using ServiceReference;
using System.Globalization;
using AvailabilityRq = Infrastructure.Connectivity.Connector.Models.Message.AvailabilityRQ;
using BookingRq = Infrastructure.Connectivity.Connector.Models.Message.BookingRQ;
using Room = Infrastructure.Connectivity.Connector.Models.Message.BookingRQ.Room;



namespace Infrastructure.Connectivity.Connector
{
    public class Connector : IConnector
    {
        private readonly IHttpWrapper _httpWrapper;
        public Connector(IHttpWrapper httpWrapper)
        {
            _httpWrapper = httpWrapper;
        }

        public async Task<(AvailabilityRS? AvailabilityRs, List<Domain.Error.Error>? Errors, AuditData AuditData)> Availability(AvailabilityConnectorQuery query)
        {
            var availabilityRQ = BuildAvalabilityRequest(query);
            var availabilityResult = await _httpWrapper.Availability(query.ConnectionData, query.AuditRequests, query.Timeout, availabilityRQ);

            return availabilityResult;
        }

        public async Task<(ValuationRS? ValuationRS, List<Domain.Error.Error>? Errors, AuditData AuditData)> Valuation(ValuationConnectorQuery query)
        {
            var hotelValuationRq = BuildValuationRequest(query);
            var response = await _httpWrapper.Valuation(query.ConnectionData, query.Timeout, hotelValuationRq);
            return response;
        }

        public async Task<(BookingRS? BookingRS, List<Domain.Error.Error>? Errors, AuditData AuditData)> CreateBooking(BookingConnectorQuery query)
        {
            var hotelBookingRulesRQ = BuildBookingRequest(query);
            var response = await _httpWrapper.Booking(query.ConnectionData, hotelBookingRulesRQ);

            return response;
        }

        public async Task<(BookingRS? BookingRS, List<Domain.Error.Error>? Errors, AuditData AuditData)> GetBookings(BookingsConnectorQuery query)
        {
            var getBookingRQ = BuildBookingGetRequest(query);
            var response = await _httpWrapper.GetBookings(query.ConnectionData, getBookingRQ);
            return response;
        }

        public async Task<(BookingRS? BookingRS, List<Domain.Error.Error>? Errors, AuditData AuditData)> CancelBooking(BookingCancelConnectorQuery query)
        {
            var getBookingRQ = BuildCancelBookingRequest(query);
            var response = await _httpWrapper.CancelBooking(query.ConnectionData, getBookingRQ);

            return response;
        }
        
        private AvailabilityRq.AvailabilityRQ BuildAvalabilityRequest(AvailabilityConnectorQuery query)
        {
            //TODO: Implement this method

            var hotelAvailRQ = new AvailabilityRQ()
            {
                RequestedAccommodations = query.SearchCriteria.Accommodations.Count
            };

            hotelAvailRQ.rq = new getAvailableHotelsRequest()
            {
                CRSysSecurity = new CRSysSecurity()
                {
                    Context = query.ConnectionData.Context,
                    Username = query.ConnectionData.Username,
                    Password = query.ConnectionData.Password,
                },
                OTA_HotelAvailRQ = new OTA_HotelAvailRQ()
                {
                    Language = query.SearchCriteria.Language,
                    DetailLevel = 0,
                    DetailLevelSpecified = true,
                    HotelSearch = new OTA_HotelAvailRQHotelSearch()
                    {
                        AvailableOnly = true,
                        AvailableOnlySpecified = true,
                        FilterNonRefundable = false,
                        FilterCancellationCostsToday = false,
                        BestOnly = false,
                        Currency = new OTA_HotelAvailRQHotelSearchCurrency() { Code = query.SearchCriteria.Currency },
                        DateRange = new OTA_HotelAvailRQHotelSearchDateRange()
                        {
                            Start = query.SearchCriteria.CheckInDate,
                            End = query.SearchCriteria.CheckOutDate
                        },
                        GuestCountry = new OTA_HotelAvailRQHotelSearchGuestCountry() { Code = query.SearchCriteria.Nationality },
                        RoomCandidates = FromRoomsToParsec(query.SearchCriteria.RoomCandidates),
                        HotelRef = FromProvidersToHotelRefs(query.SearchCriteria.Accommodations)
                    },
                }
            };
            return hotelAvailRQ;
        }

        private OTA_HotelAvailRQHotelSearchHotelRef FromProvidersToHotelRefs(IList<string> accomodations)
        {
            return new OTA_HotelAvailRQHotelSearchHotelRef() { HotelCode = System.String.Join(",", accomodations) };
        }

        private OTA_HotelAvailRQHotelSearchRoomCandidate[] FromRoomsToParsec(IList<Infrastructure.Connectivity.Queries.Room> data)
        {
            var rooms = new OTA_HotelAvailRQHotelSearchRoomCandidate[data.Count];
            for (int i = 0; i < data.Count; i++)
            {
                rooms[i] = new OTA_HotelAvailRQHotelSearchRoomCandidate()
                {
                    RPH = data[i].RoomRefId.ToString(),
                };

                var Guests = new List<OTA_HotelAvailRQHotelSearchRoomCandidateGuest>();

                // Pax adultos sólo llevan el tipo A y la Cantidad de pax
                if (data[i].Pax.Any(x => x.Age >= ServiceConf.ChildrenAge))
                {
                    var adultGuests = new OTA_HotelAvailRQHotelSearchRoomCandidateGuest()
                    {
                        Count = data[i].Pax.Count(y => y.Age >= ServiceConf.ChildrenAge),
                        AgeCode = OTA_HotelAvailRQHotelSearchRoomCandidateGuestAgeCode.A
                    };
                    Guests.Add(adultGuests);
                }

                // Pax CHD llevan el tipo C,  la Cantidad de pax y la edad
                if (data[i].Pax.Any(x => x.Age < ServiceConf.ChildrenAge))
                {
                    var groupChildren = data[i].Pax.GroupBy(j => j.Age)
                        .Where(z => z.Key < ServiceConf.ChildrenAge)
                        .Select(x => new { Age = x.Key, Count = x.Count() }).ToList();
                    groupChildren.ForEach(j =>
                    {
                        var childGuest = new OTA_HotelAvailRQHotelSearchRoomCandidateGuest()
                        {
                            Count = j.Count,
                            AgeCode = OTA_HotelAvailRQHotelSearchRoomCandidateGuestAgeCode.C,
                            Age = j.Age,
                            AgeSpecified = true
                        };
                        Guests.Add(childGuest);
                    });
                }
                rooms[i].Guests = Guests.ToArray();
            }
            return rooms;
        }

        private Models.Message.ValuationRQ.ValuationRQ BuildValuationRequest(ValuationConnectorQuery query)
        {
            // TODO: Implement this method
            var valuationRq = new ValuationRQ()
            {
                Header = new BookingSecurityRQ
                {
                    CRSysSecurity = new SysSecurity()
                    {
                        Context = query.ConnectionData.Context,
                        Username = query.ConnectionData.Username,
                        Password = query.ConnectionData.Password,
                    }
                },
                Body = new BookingBodyRQ
                {
                    OTA_HotelResRQ = new HotelResRQ()
                    {
                        RoomInfo = true,
                        Transaction = Transaction.PreBooking,
                        HotelRes = new Infrastructure.Connectivity.Connector.Models.Message.BookingRQ.HotelRes()
                        {
                            Rooms = GetPreBookRooms(query.ValuationCode)
                        }
                    }
                }
            };
            return valuationRq;
        }

        private List<Room> GetPreBookRooms(ValuationCode vc)
        {
            var result = new List<Room>();
            for (int i = 0; i < vc.RoomsRef.Length; i++)
            {
                result.Add(
                    new Room()
                    {
                        RoomRate = new Connectivity.Connector.Models.Message.BookingRQ.RoomRate()
                        {
                            BookingCode = vc.BokingCode.ToString()
                        }
                    });
            }
            return result;
        }

        private Models.Message.BookingRQ.BookingRQ BuildBookingRequest(BookingConnectorQuery query)
        {
            // TODO: Implement this method
            var vc = query.ValuationCode;
            var bc = query.BookingCode;

            var crSysSecurity = new SysSecurity()
            {
                Context = query.ConnectionData.Context,
                Username = query.ConnectionData.Username,
                Password = query.ConnectionData.Password
            };

            var ota_HotelResRQ = new HotelResRQ()
            {
                DetailLevel = 2,
                RateDetails = true,
                Transaction = Transaction.Booking,
                UniqueID = new UniqueID()
                {
                    ID = query.ClientReference,
                    Type = UniqueIDType.ClientReference,
                },
                HotelRes = new Infrastructure.Connectivity.Connector.Models.Message.BookingRQ.HotelRes()
                {
                    Rooms =ToBookingRooms(query.Rooms, bc.BookCode).ToList()
                }
            };

            return new BookingRQ
            {
                Body = new BookingBodyRQ { OTA_HotelResRQ = ota_HotelResRQ },
                Header = new BookingSecurityRQ { CRSysSecurity = crSysSecurity }
            };
        }
        
        private List<Connectivity.Connector.Models.Message.BookingRQ.Room> ToBookingRooms(IList<Connectivity.Queries.BookingRoom> rooms, string bookingCode)
        {
            var results = new List<Connectivity.Connector.Models.Message.BookingRQ.Room>();
            foreach (var room in rooms)
            {
                var guests = new List<Guest>();
                foreach (var guest in room.Paxes)
                {
                    var newGuest = new Guest();
                    newGuest.PersonName = new PersonName();
                    newGuest.PersonName.GivenName = guest.Name;
                    newGuest.PersonName.Surname = guest.Surname;
                    newGuest.PersonName.NamePrefix = "Mr.";
                    //newGuest.LeadGuest = guest.Holder; Preguntar que es esto
                    newGuest.AgeCode = guest.Age >= ServiceConf.ChildrenAge ? GuestAgeCode.A : GuestAgeCode.C;

                    if (guest.Age < ServiceConf.ChildrenAge)
                        newGuest.Age = guest.Age.Value;

                    guests.Add(newGuest);
                }

                var newRoom = new Connectivity.Connector.Models.Message.BookingRQ.Room();
                newRoom.RoomRate = new Connectivity.Connector.Models.Message.BookingRQ.RoomRate() { BookingCode = bookingCode };
                newRoom.Guests = guests;

                results.Add(newRoom);
            }

            return results;
        }
        
        private Models.Message.BookingRQ.BookingRQ BuildBookingGetRequest(BookingsConnectorQuery query)
        {
            //TODO: Implement this method
            var resId = query.Locator;

            var result = new BookingRQ()
            {
                Header = new BookingSecurityRQ
                {
                    CRSysSecurity = new SysSecurity()
                    {
                        Context = query.ConnectionData.Context,
                        Username = query.ConnectionData.Username,
                        Password = query.ConnectionData.Password,
                    }
                },
                Body = new BookingBodyRQ
                {
                    OTA_ReadRQ = new ReadRQ
                    {
                        UniqueID = new UniqueID
                        {
                            ID = resId,
                            Type = UniqueIDType.Locator
                        }
                    }
                }
            };
            return result;
        }

        private Models.Message.BookingRQ.BookingRQ BuildCancelBookingRequest(BookingCancelConnectorQuery query)
        {
            //TODO: Implement this method
            var resId = query.Locator;

            var result = new BookingRQ()
            {
                Header = new BookingSecurityRQ
                {
                    CRSysSecurity = new SysSecurity()
                    {
                        Context = query.ConnectionData.Context,
                        Username = query.ConnectionData.Username,
                        Password = query.ConnectionData.Password,
                    }
                },
                Body = new BookingBodyRQ
                {
                    OTA_CancelRQ = new CancelRQ
                    {
                        Transaction = "Cancel",
                        UniqueID = new UniqueID
                        {
                            ID = resId,
                            Type = UniqueIDType.Locator
                        }
                    }
                }
            };
            return result;
        }

    }
}
