using Application.Dto.AvailabilityService;
using Application.Dto.BookingCancelService;
using Application.Dto.BookingCreateService;
using Application.Dto.BookingsService;
using Application.Dto.Common;
using Application.Dto.ValuationService;
using Domain.Availability;
using Domain.Booking;
using Domain.Valuation;

using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
//using Prg = IJuniperApi

namespace Ijuniper.test
{
    public class Tests
    {
        private HttpClient _client;

        [SetUp]
        public void Setup()
        {
            var application = new Microsoft.AspNetCore.Mvc.Testing.WebApplicationFactory<Program>();
            _client = application.CreateClient();
        }


        [Test]
        public async Task MethodIbossyAvailability()
        {
            AvailabilityQuery query = new AvailabilityQuery()
            {

                ExternalSupplier = new ExternalSupplier()
                {

                    Code = "IPaximum",
                    Connection = new System.Collections.Generic.Dictionary<string, string>()
                    {
                        {"Url", "https://staging.olympiaeurope.com/NewAvailabilityServlet/hotelavail/OTA2014Compact"},
                        {"Password", "5a70e77bc3"},
                        {"Username", "628834"},
                        {"Context", "olympia_europe"}
                    }
                    ,
                    Params = new System.Collections.Generic.Dictionary<string, string>()
                    {
                        { "NumberAccommodationPerRequest", "150" }
                    }
                },
                SearchCriteria = new SearchCriteria()
                {
                    AccommodationCodes = new List<string>() {
                        "33402","316994","15892"
                    },
                    CheckIn = new DateTime(2025, 07, 17),
                    CheckOut = new DateTime(2025, 07, 18),
                    Currency = "EUR",
                    Language = "ES",
                    Nationality = "IT",
                    RoomCandidates = new List<Application.Dto.AvailabilityService.Room>() {
                         new Application.Dto.AvailabilityService.Room(){
                            PaxesAge = new List<byte>(){ 30},
                            RoomRefId = 1
                        },
                        new Application.Dto.AvailabilityService.Room(){
                            PaxesAge = new List<byte>(){ 30,30},
                            RoomRefId = 2
                        },
                     }
                },
                Timeout = 100000,
                AuditRequests = true,
                Include = new Dictionary<string, List<string>>()
                {
                    {"accommodations", new(){"name"} },
                    {"remarks", new(){ } },
                    {"fees", new(){ } },
                    {"rooms", new(){"name", "description", "occupancy" } },
                    {"occupancy", new(){ } },
                    {"cancellationpolicy", new(){ } },
                    {"promotions", new(){ } },
                    {"mealplan", new(){ "name" } },
                    {"root", new (){"paymenttype", "code", "name", "remarks" }},
                    {"price", new(){ } },
                    {"bookings", new (){"cancellocator", "hcn", "checkin", "checkout", "clientreference", "comments" } },
                    {"holder", new(){ } },
                    {"hotel", new(){ "name" } },
                    {"paxes", new(){ "title", "address", "country", "city", "age", "document", "email", "idpax", "phonenumber", "postalcode" } }
                },
            };
            HttpRequestMessage request = GetRequest("api/Availability"
                , "BEDBDDDB5813A41E2B248329CDB4C884B23D0FF4F95C6AA10840B8B761B059F3");
            request.Content = new StringContent(Serializar(query), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.SendAsync(request);
            string responseString = await response.Content.ReadAsStringAsync();
           // responseString = responseString.Replace("\"", "");
            Availability trueObject = Deserializar<Availability>(responseString);
            Assert.IsNotNull(trueObject.Accommodations);

            TestContext.Out.WriteLine(trueObject.Accommodations[0].Mealplans[0].Combinations[0].ValuationCode);
            var refundableComb = trueObject.Accommodations[0].Mealplans[0].Combinations.FirstOrDefault(x => !(bool)x.NonRefundable);
            if (refundableComb != null)
            {
                TestContext.Out.WriteLine("valcode:" + refundableComb.ValuationCode);
                TestContext.Out.WriteLine("Policy:" + refundableComb.CancellationPolicy.PenaltyRules[0].DateFrom);
            }
        }

        [Test]
        public async Task MethodValuation()
        {

            var vc = "33402^[p4j7qdMid1rYauo/JWqoSjKKM/QOQCwQhF8SNcMdJh0rmfxita5Qfa+0ZxPnzEoPyGZGZ/c6sNjxi+aQ5ZuK/gGxiKHh8Gg5MGa2lC2QTePURpQPdyojy32LZyltQonQfNoUEv5VKu0eH04jyu0rdVVDqoOMB5YV5mx13zYzcPBJ6QolW/3oWWXDfTIiR3h18oNY7qe5NBJOSFXf52Ay/8JmX2C+/6An21LLwPR1SxT0aNHtkgR9UVTpixhbPnEFvijIvDpmtmuQKHkS7m2RemnATzJFkH9fa5VuJ5VfzUxQ6f2qlp94Rv1q3/Zkaa1c__p4j7qdMid1rYauo/JWqoSonubPrK37OzlcNdN5FGtXwrmfxita5Qfa+0ZxPnzEoPnbb/wigQdJmplULTERXbOXZj2iVGQmAWwdvKNTRrDYvdkdw8ZjP65vDFlPIMOOqjfNoUEv5VKu0eH04jyu0rdVVDqoOMB5YV5mx13zYzcPBJ6QolW/3oWWXDfTIiR3h18oNY7qe5NBJOSFXf52Ay/7LWHkwhQYrkq7JlvKk5kKjO5uIz5KVFyPAvdsjvcbryndXtcKj+m/5m7okQGUzvLeyCCk9gey3js8DfV80tJqr64fL/nZ1nnbjBPYf2O29r/t0O7cOlPUA+Fof+C02D9A==^[1__2^[2025-07-17";

            var valRequest = GetRequest("api/Valuation", "BEDBDDDB5813A41E2B248329CDB4C884B23D0FF4F95C6AA10840B8B761B059F3");
            ValuationQuery valQuery = new ValuationQuery()
            {
                ExternalSupplier = new ExternalSupplier()
                {

                    Code = "IPaximum",
                    Connection = new System.Collections.Generic.Dictionary<string, string>()
                    {
                        {"Url", "https://staging.olympiaeurope.com/NewAvailabilityServlet/hotelres/OTA2014Compact"},
                        {"Password", "5a70e77bc3"},
                        {"Username", "628834"},
                        {"Context", "olympia_europe"}
                    }
                    ,
                    Params = new System.Collections.Generic.Dictionary<string, string>()
                    {
                        { "NumberAccommodationPerRequest", "150" }
                    }
                },
                ValuationCode = vc,
                Include = new Dictionary<string, List<string>>()
                {
                    {"accommodations", new(){"name"} },
                    {"remarks", new(){ } },
                    {"fees", new(){ } },
                    {"rooms", new(){"name", "description", "occupancy" } },
                    {"occupancy", new(){ } },
                    {"cancellationpolicy", new(){ } },
                    {"promotions", new(){ } },
                    {"mealplan", new(){ "name" } },
                    {"root", new (){"paymenttype", "code", "name", "remarks" }},
                    {"price", new(){ } },
                    {"bookings", new (){"cancellocator", "hcn", "checkin", "checkout", "clientreference", "comments" } },
                    {"holder", new(){ } },
                    {"hotel", new(){ "name" } },
                    {"paxes", new(){ "title", "address", "country", "city", "age", "document", "email", "idpax", "phonenumber", "postalcode" } }
                },
                Timeout = 100000,
            };
            // valQuery = JsonSerializer.Deserialize<ValuationQuery>(vc, Extension.Configure());
            valRequest.Content = new StringContent(Serializar(valQuery), Encoding.UTF8, "application/json");

            var valResponse = await _client.SendAsync(valRequest);
            var varResponseString = await valResponse.Content.ReadAsStringAsync();
            var valTrueObject = Deserializar<Valuation>(varResponseString);
            TestContext.Out.WriteLine(Serializar(valTrueObject));
            TestContext.Out.WriteLine(valTrueObject.Price.Purchase.Cost.Amount.ToString());

            Assert.IsNotNull(valTrueObject.Rooms);
        }

        [Test]
        public async Task MethodBooking()
        {
            var bc = "15892^[p4j7qdMid1rYauo/JWqoStQ8BdyMKFpyemwsMuTToSvkH5nPI7qieY+ulwEVAlWZ0M5Orw+/edu5yuY9KTfTVxFnqn5cn9llvj5z2wxuuXS+YnoMBBP0CizWYh2q2jevRM2dbQWp6Pzm0BNJbfy7og5YRCX+g290M92mqR6HF4Jca1p3fZ867c0PrhYgS36UuK92zQSVGTHp/slsMPTmk6lHoi5UmZ/yLiZWe2oF5++++fI9L8yLO1zV0lPCu9/Lco6W0i2teataXVCi4uKFKMAg7thIvqz8ncvkKmGB7Fo7yBESY0peUs5LNZPPU+IwIoYTU1CUxt9/sa9B2l9zBQ==__p4j7qdMid1rYauo/JWqoStQ8BdyMKFpyemwsMuTToSvkH5nPI7qieY+ulwEVAlWZcEadh9I8te6PUz4S1I9IDhjRGFmIl+hN5idP0uAufIC+YnoMBBP0CizWYh2q2jevRM2dbQWp6Pzm0BNJbfy7og5YRCX+g290M92mqR6HF4Jca1p3fZ867c0PrhYgS36UuK92zQSVGTHp/slsMPTmk6lHoi5UmZ/yLiZWe2oF5++++fI9L8yLO1zV0lPCu9/Lco6W0i2teataXVCi4uKFKMAg7thIvqz8ncvkKmGB7Fo7yBESY0peUs5LNZPPU+IwBw2IupXY7g+p4ux3lymqqQ==^[1__2^[2025-07-17";


            var bookRequest = GetRequest("api/Booking/create", "BEDBDDDB5813A41E2B248329CDB4C884B23D0FF4F95C6AA10840B8B761B059F3");
            BookingCreateQuery bookQuery = new BookingCreateQuery()
            {
                ExternalSupplier = new ExternalSupplier()
                {
                    Code = "IPaximum",
                    Connection = new System.Collections.Generic.Dictionary<string, string>()
                    {
                        {"Url", "https://staging.olympiaeurope.com/NewAvailabilityServlet/hotelres/OTA2014Compact"},
                        {"Password", "5a70e77bc3"},
                        {"Username", "628834"},
                        {"Context", "olympia_europe"}
                    }
                    ,
                    Params = new System.Collections.Generic.Dictionary<string, string>()
                    {
                        { "NumberAccommodationPerRequest", "150" }
                    }
                }
                ,
                BookingCode = bc
                ,
                Locator = "Test" + DateTime.Now.Ticks.ToString()
                ,
                Rooms = new List<Application.Dto.BookingCreateService.Room>()
                {
                    new Application.Dto.BookingCreateService.Room(){
                        Paxes = new List<Application.Dto.BookingCreateService.Pax>(){
                            new Pax(){ Id = 1,Name = "Nino", Surname = "Rac", Age = 30, Title="Mr.", Email = "test@test.test"}
                        },
                    },
                    new Application.Dto.BookingCreateService.Room(){
                        Paxes = new List<Application.Dto.BookingCreateService.Pax>(){
                            new Pax(){ Id = 1,Name = "Test1", Surname = "Test1", Age = 30, Title="Mr.", Email = "test@test.test"},
                            new Pax(){ Id = 2,Name = "Test2", Surname = "Test2", Age = 30, Title="Mr.",  Email = "test@test.test"}
                        },
                     },
                },
                Holder = new Pax() { Id = 1, Name = "Nino", Surname = "Rac" },
                Include = new Dictionary<string, List<string>>()
                {
                    {"accommodations", new(){"name"} },
                    {"remarks", new(){ } },
                    {"fees", new(){ } },
                    {"rooms", new(){"name", "description", "occupancy" } },
                    {"occupancy", new(){ } },
                    {"cancellationpolicy", new(){ } },
                    {"promotions", new(){ } },
                    {"mealplan", new(){ "name" } },
                    {"root", new (){"paymenttype", "code", "name", "remarks" }},
                    {"price", new(){ } },
                    {"bookings", new (){"cancellocator", "hcn", "checkin", "checkout", "clientreference", "comments" } },
                    {"holder", new(){ } },
                    {"hotel", new(){ "name" } },
                    {"paxes", new(){ "title", "address", "country", "city", "age", "document", "email", "idpax", "phonenumber", "postalcode" } }

                },
                Remarks = "Test",
                Tolerance = new Tolerance()
                {
                    Type = ToleranceType.Percentage,
                    Value = 10
                }
            };
            bookRequest.Content = new StringContent(Serializar(bookQuery), Encoding.UTF8, "application/json");
            var bookResponse = await _client.SendAsync(bookRequest);
            var bookresponseString = await bookResponse.Content.ReadAsStringAsync();
            var booktrueObject = Deserializar<Booking>(bookresponseString);
            TestContext.Out.WriteLine(booktrueObject.BookingId);
            TestContext.Out.WriteLine(booktrueObject.HCN);
            TestContext.Out.WriteLine(booktrueObject.ClientReference);
        }

        [Test]
        public async Task MethodCancelBooking()
        {

            var cancelrequest = GetRequest("api/Booking/cancel", "BEDBDDDB5813A41E2B248329CDB4C884B23D0FF4F95C6AA10840B8B761B059F3", HttpMethod.Put);
            var resNo = "4207837"; //
            BookingCancelQuery cancelQuery = new BookingCancelQuery()
            {
                ExternalSupplier = new ExternalSupplier()
                {
                    Code = "IPaximum",
                    Connection = new System.Collections.Generic.Dictionary<string, string>()
                    {
                        {"Url", "https://staging.olympiaeurope.com/NewAvailabilityServlet/hotelcancel/OTA2014Compact"},
                        {"Password", "5a70e77bc3"},
                        {"Username", "628834"},
                        {"Context", "olympia_europe"}
                    }
                    ,
                    Params = new System.Collections.Generic.Dictionary<string, string>()
                    {
                        { "NumberAccommodationPerRequest", "150" }
                    }
                },
                BookingId = resNo,
                Include = new Dictionary<string, List<string>>()
                {
                   {"accommodations", new(){"name"} },
                    {"remarks", new(){ } },
                    {"fees", new(){ } },
                    {"rooms", new(){"name", "description", "occupancy" } },
                    {"occupancy", new(){ } },
                    {"cancellationpolicy", new(){ } },
                    {"promotions", new(){ } },
                    {"mealplan", new(){ "name" } },
                    {"root", new (){"paymenttype", "code", "name", "remarks" }},
                    {"price", new(){ } },
                    {"bookings", new (){"cancellocator", "hcn", "checkin", "checkout", "clientreference", "comments" } },
                    {"holder", new(){ } },
                    {"hotel", new(){ "name" } },
                    {"paxes", new(){ "title", "address", "country", "city", "age", "document", "email", "idpax", "phonenumber", "postalcode" } }
                },


            };
            cancelrequest.Content = new StringContent(Serializar(cancelQuery), Encoding.UTF8,
           "application/json");
            var cancelresponse = await _client.SendAsync(cancelrequest);
            var cancelresponseString = await cancelresponse.Content.ReadAsStringAsync();

            var canceltrueObject = Deserializar<Booking>(cancelresponseString);
            Assert.IsNotNull(canceltrueObject.CancelLocator);
        }

        [Test]
        public async Task MethodGetBooking()
        {
            var resNo = "4207837"; //
            var clientReference = "Test638664114604602909";
            //8047080112
            var request = GetRequest("api/Booking/get", "BEDBDDDB5813A41E2B248329CDB4C884B23D0FF4F95C6AA10840B8B761B059F3", HttpMethod.Post);
            BookingsQuery query = new BookingsQuery()
            {

                ExternalSupplier = new ExternalSupplier()
                {
                    Code = "IPaximum",
                    Connection = new System.Collections.Generic.Dictionary<string, string>()
                    {
                        {"Url", "https://staging.olympiaeurope.com/NewAvailabilityServlet/reservationsread/OTA2014Compact"},
                        {"Password", "5a70e77bc3"},
                        {"Username", "628834"},
                        {"Context", "olympia_europe"}
                    }
                    ,
                    Params = new System.Collections.Generic.Dictionary<string, string>()
                    {
                        { "NumberAccommodationPerRequest", "150" }
                    }
                },
                //ClientReference = clientReference,
                BookingId = resNo,

                Include = new Dictionary<string, List<string>>()
                {
                   {"accommodations", new(){"name"} },
                    {"remarks", new(){ } },
                    {"fees", new(){ } },
                    {"rooms", new(){"name", "description", "occupancy" } },
                    {"occupancy", new(){ } },
                    {"cancellationpolicy", new(){ } },
                    {"promotions", new(){ } },
                    {"mealplan", new(){ "name" } },
                    {"root", new (){"paymenttype", "code", "name", "remarks" }},
                    {"price", new(){ } },
                    {"bookings", new (){"cancellocator", "hcn", "checkin", "checkout", "clientreference", "comments" } },
                    {"holder", new(){ } },
                    {"hotel", new(){ "name" } },
                    {"paxes", new(){ "title", "address", "country", "city", "age", "document", "email", "idpax", "phonenumber", "postalcode" } }
                },


            };
            request.Content = new StringContent(Serializar(query), Encoding.UTF8, "application/json");
            var bookResponse = await _client.SendAsync(request);
            var bookresponseString = await bookResponse.Content.ReadAsStringAsync();

            var booktrueObject = Deserializar<Bookings>(bookresponseString);
            Assert.IsNotNull(booktrueObject.BookingList);
        }

       

        private HttpRequestMessage GetRequest(string method, string apikey, HttpMethod Hmethod = null)
        {
            if (Hmethod == null)
            {
                Hmethod = HttpMethod.Post;
            }
            var request = new HttpRequestMessage(Hmethod, method);
            request.Headers.Add("x-api-key", apikey);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return request;
        }

        public static string Serializar<T>(T objeto)
        {
            var opciones = new JsonSerializerOptions
            {
                WriteIndented = true // Formato legible con sangr�a (opcional)
            };
            return JsonSerializer.Serialize(objeto, opciones);
        }

        // M�todo para deserializar un JSON a un objeto
        public static T Deserializar<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }

    }
}