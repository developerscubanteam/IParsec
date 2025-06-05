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
                    { "accommodations", new List<string>(){ "name" } },
                    { "remarks", null },
                    { "fees", null },
                    { "rooms", new List<string>(){"name", "description", "occupancy" } },
                    { "cancellationpolicy", null },
                    { "promotions", null },
                    { "mealplan", new List<string>(){ "name"} },
                    { "root", new List<string>(){ "paymenttype","code","name" }},
                    { "price", null },
                    { "hotel", new List<string>(){"name" } }
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

            var vc = "15892^[p4j7qdMid1rYauo/JWqoSjNH3i017CN94XctPAMq8Z/kH5nPI7qieY+ulwEVAlWZbP1n8qmrwXNGH2Ndn8QNHRFnqn5cn9llvj5z2wxuuXQbt/FSEe+mwJcAoW8Kd+xcRM2dbQWp6Pzm0BNJbfy7og5YRCX+g290M92mqR6HF4Jca1p3fZ867c0PrhYgS36UuK92zQSVGTHp/slsMPTmk1W4aQqb3lm4gwagTVEhh42VMvyY7/799z0ilIor/ElAfsHIi4rUhOba/Jiw7SJSY+YE90BQ9i5Nry17fRWWbEBpKimyfwg3LkEjvII+q6Ii__p4j7qdMid1rYauo/JWqoSqSJODu+tk1wOHdwK2jLbdT0vWVBINFKfDi4MT6Qnbc4yNxfPz+A9hbbD2J6JKokjxjRGFmIl+hN5idP0uAufIAbt/FSEe+mwJcAoW8Kd+xcRM2dbQWp6Pzm0BNJbfy7og5YRCX+g290M92mqR6HF4Jca1p3fZ867c0PrhYgS36UuK92zQSVGTHp/slsMPTmk1W4aQqb3lm4gwagTVEhh42TFi9jfBd2laP9qmL5VLEsfsHIi4rUhOba/Jiw7SJSY+YE90BQ9i5Nry17fRWWbEBpKimyfwg3LkEjvII+q6Ii^[1__2^[2025-07-17";

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
                    { "accommodations", new List<string>(){ "name" } },
                    { "root", new List<string>(){ "remarks" } },
                    { "cancellationpolicy", null},
                    { "mealplan", new List<string>(){ "name" } },
                    { "fees", null},
                    { "rooms", null},
                    { "occupancy", null},
                    { "price", null},


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
            var bc = "15892^[p4j7qdMid1rYauo/JWqoSjNH3i017CN94XctPAMq8Z/kH5nPI7qieY+ulwEVAlWZbP1n8qmrwXNGH2Ndn8QNHRFnqn5cn9llvj5z2wxuuXQbt/FSEe+mwJcAoW8Kd+xcRM2dbQWp6Pzm0BNJbfy7og5YRCX+g290M92mqR6HF4Jca1p3fZ867c0PrhYgS36UuK92zQSVGTHp/slsMPTmk1W4aQqb3lm4gwagTVEhh42VMvyY7/799z0ilIor/ElAfsHIi4rUhOba/Jiw7SJSY+YE90BQ9i5Nry17fRWWbEBpKimyfwg3LkEjvII+q6Ii__p4j7qdMid1rYauo/JWqoSqSJODu+tk1wOHdwK2jLbdT0vWVBINFKfDi4MT6Qnbc4yNxfPz+A9hbbD2J6JKokjxjRGFmIl+hN5idP0uAufIAbt/FSEe+mwJcAoW8Kd+xcRM2dbQWp6Pzm0BNJbfy7og5YRCX+g290M92mqR6HF4Jca1p3fZ867c0PrhYgS36UuK92zQSVGTHp/slsMPTmk1W4aQqb3lm4gwagTVEhh42TFi9jfBd2laP9qmL5VLEsfsHIi4rUhOba/Jiw7SJSY+YE90BQ9i5Nry17fRWWbEBpKimyfwg3LkEjvII+q6Ii^[1__2^[2025-07-17";


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
                    { "accommodations", new List<string>(){ "name" } },
                    { "root", new List<string>(){ "remarks" } },
                    { "cancellationpolicy", null},
                    { "mealplan", new List<string>(){ "name" } },
                    { "fees", null},
                    { "rooms", null},
                    { "occupancy", null},
                    { "price", null},

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
            var resNo = "GOB07105409WDA4A9JW1P|Test638665772348560358"; //
            BookingCancelQuery cancelQuery = new BookingCancelQuery()
            {
                ExternalSupplier = new ExternalSupplier()
                {
                    Code = "IPaximum",
                    Connection = new System.Collections.Generic.Dictionary<string, string>()
                    {

                        { "Url","http://api.stage.paximum.com"},
                        { "ApiKey","eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkYjkwZmJmZi03YWNkLTQyNDctYmZlNi01MTk4NzkwNWJlNzIiLCJyb2xlIjoiYjJjOmFwcCIsIm5iZiI6MTcyNDY1NjQwMSwiZXhwIjoxODgyNDIyNzYyLCJpYXQiOjE3MjQ2NTY0MDEsImlzcyI6Imh0dHBzOi8vYXV0aC5wYXhpbXVtLmNvbSIsImF1ZCI6Imh0dHBzOi8vYXBpLnBheGltdW0uY29tIn0.iBfdfn6wSUFsjC1lGcZNd9cYFRmAjktNx_cFiIx0Oak"},
                    }
                },
                BookingId = resNo,
                Include = new Dictionary<string, List<string>>()
                {
                    { "accommodations", new List<string>(){ "name" } },
                    { "remarks", null },
                    { "cancellationpolicy", null},
                    { "mealplan", new List<string>(){ "name" } },
                    { "fees", null},
                    { "rooms", null},
                    { "price", null},
                    { "cancellocator", null}

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
            var resNo = "d5217632-eb64-4983-bfae-d5943926f1c4"; //
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

                        { "Url","http://api.stage.paximum.com"},
                        { "ApiKey","eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkYjkwZmJmZi03YWNkLTQyNDctYmZlNi01MTk4NzkwNWJlNzIiLCJyb2xlIjoiYjJjOmFwcCIsIm5iZiI6MTcyNDY1NjQwMSwiZXhwIjoxODgyNDIyNzYyLCJpYXQiOjE3MjQ2NTY0MDEsImlzcyI6Imh0dHBzOi8vYXV0aC5wYXhpbXVtLmNvbSIsImF1ZCI6Imh0dHBzOi8vYXBpLnBheGltdW0uY29tIn0.iBfdfn6wSUFsjC1lGcZNd9cYFRmAjktNx_cFiIx0Oak"},
                    }
                },
                //ClientReference = clientReference,
                BookingId = resNo,

                Include = new Dictionary<string, List<string>>()
                {
                    { "accommodations", new List<string>(){ "name" } },
                    { "remarks", null },
                    { "cancellationpolicy", null},
                    { "mealplan", new List<string>(){ "name" } },
                    { "fees", null},
                    { "rooms", null},
                    { "price", null}

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
                WriteIndented = true // Formato legible con sangría (opcional)
            };
            return JsonSerializer.Serialize(objeto, opciones);
        }

        // Método para deserializar un JSON a un objeto
        public static T Deserializar<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }

    }
}