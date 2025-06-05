using Domain.Common;
using Domain.Error;
using Domain.ValuationCode;
using Infrastructure.Connectivity.Connector.Models;
using Infrastructure.Connectivity.Connector.Models.Message.AvailabilityRS;
using Infrastructure.Connectivity.Connector.Models.Message.BookingRS;
using Infrastructure.Connectivity.Connector.Models.Message.ValuationRS;
using Infrastructure.Connectivity.Contracts;
using Infrastructure.Connectivity.Queries.Base;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Xml;
using Message = Infrastructure.Connectivity.Connector.Models.Message;

namespace Infrastructure.Connectivities.Iboosy.Connector.HttpWrapper
{
    public class UrlPath
    {
        //TODO: Change the path to the correct one
        public const string Shopping = "RQtP.Availability";
        //public const string LiveCheck = "availability";
        public const string PreBook = "RQtP.Valuation";
        public const string Booking = "RQtP.CreateBooking";
        public const string CancelBooking = "RQtP.CancelBooking";
        public const string GetBookings = "RQtP.GetBooking";
    }
    public class HttpWrapper : IHttpWrapper
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HttpWrapper(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<(Message.AvailabilityRS.AvailabilityRS? AvailabilityRs, List<Domain.Error.Error>? Errors, AuditData AuditData)> Availability(ConnectionData connectionData, bool auditRequests, int? timeout, object query)
        {
            const string c_Method = UrlPath.Shopping;
            var timeoutRq = timeout.HasValue ? timeout.Value : 20000;
            var processTime = Stopwatch.StartNew();
            var auditData = new AuditData() { Requests = new List<Request>() };
            var auditRequest = new Request() { RequestName = c_Method, TimeStamp = DateTime.UtcNow };
            var rqString =  query.SerializeObjectXml(); 
            var responseString = "";

            try
            { 

                if (auditRequests)
                    auditData.Requests.Add(new Request() { RQ = rqString });

                var client = _httpClientFactory.CreateClient(ServiceConf.ClientName);
                // client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", connectionData.Token);
                client.Timeout = TimeSpan.FromMilliseconds(timeout.Value);

                var separator = connectionData.Url.EndsWith("/") ? "" : "/";
                var uri = new Uri(connectionData.Url);

                var message = new HttpRequestMessage(HttpMethod.Post, uri)
                {
                    Content = new StringContent(rqString, Encoding.UTF8, "text/xml")
                };

                var responseMessage = await client.SendAsync(message, HttpCompletionOption.ResponseHeadersRead);
                responseString = await responseMessage.Content.ReadAsStringAsync();


                if (responseMessage.StatusCode == HttpStatusCode.OK)
                {
                    var resultString = responseString;
                    var response = resultString.DeserializeXml<Message.AvailabilityRS.AvailabilityRS>();

                    var errors = new List<Domain.Error.Error>();

                    if (response.Errors != null && response.Errors.Any())
                    {
                        errors.AddRange(CheckError(response.Errors));
                    }

                    if (errors.Any())
                    {
                        auditRequest.Type = AuditDataType.KO;
                        return (null, errors, auditData);
                    }

                    var error = IsEmptyResult(response); 
                    if (error != null)
                    {
                        auditRequest.Type = AuditDataType.NoResults;
                        return (null, error, auditData);
                    }                   

                    auditRequest.Type = AuditDataType.Ok;
                    return (response, null, auditData);
                }
                else
                {
                    //TODO: Implement the error handling
                    var error = new Message.Common.Error() { };
                    auditRequest.Type = AuditDataType.KO;
                    return (null, SupplierError(error), auditData);
                }
            }
            catch (TaskCanceledException)
            {
                auditRequest.Type = AuditDataType.Timeout;
                return (null, TimeoutError(), auditData);
            }
            catch (Exception ex)
            {
                auditRequest.Type = AuditDataType.KO;
                return (null, UncontrolledError(ex), auditData);
            }
            finally
            {
                auditData.NumberOfRequests = 1;                
                if (auditRequests)
                {
                    auditRequest.ProcessTime = processTime.ElapsedMilliseconds;
                    auditRequest.RQ = rqString;
                    auditRequest.RS = responseString;
                }
                auditData.Requests.Add(auditRequest);
            }
        }

        public async Task<(ValuationRS? ValuationRS, List<Domain.Error.Error>? Errors, AuditData AuditData)> Valuation(ConnectionData connectionData, int? timeout, object query)
        {
            var timeoutRq = timeout.HasValue ? timeout.Value : ServiceConf.TimeoutValuation;
            var c_Method = UrlPath.PreBook;
            var processTime = Stopwatch.StartNew();

            var auditData = new AuditData() { Requests = new List<Request>() };
            var auditRequest = new Request() { RequestName = c_Method, TimeStamp = DateTime.UtcNow };
            var rqString = query.SerializeObjectXml();
            var responseString = "";
            var response = new HotelValuationRS();

            try
            {
                var client = _httpClientFactory.CreateClient("Av");
                // client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", connectionData.Token);
                client.Timeout = TimeSpan.FromMilliseconds(timeoutRq);

                var separator = connectionData.Url.EndsWith("/") ? "" : "/";

                var uri = new Uri(connectionData.Url);
                client.BaseAddress = uri;

                var message = new HttpRequestMessage(HttpMethod.Post, uri)
                {
                    Content = new StringContent(rqString, Encoding.UTF8, "text/xml")
                };

                var responseMessage = await client.SendAsync(message, HttpCompletionOption.ResponseHeadersRead);
                responseString = await responseMessage.Content.ReadAsStringAsync();              

                if (responseMessage.StatusCode == HttpStatusCode.OK)
                {
                    var resultLiveCheckString = responseString;
                    response = resultLiveCheckString.DeserializeXml<Message.ValuationRS.HotelValuationRS>();

                    var errors = new List<Domain.Error.Error>();

                    if (response.Errors != null && response.Errors.Any())
                    {
                        errors.AddRange(CheckError(response.Errors));
                    }

                    if (errors.Any())
                    {
                        auditRequest.Type = AuditDataType.KO;
                        return (null, errors, auditData);
                    }

                    
                    auditRequest.Type = AuditDataType.Ok;
                    return (new ValuationRS() { results = response, vc = null }, null, auditData);
                }
                else
                {
                    //TODO: Implement the error handling
                    var error = new Message.Common.Error() {  };
                    auditRequest.Type = AuditDataType.KO;
                    return (null, SupplierError(error), auditData);
                }
            }
            catch (TaskCanceledException)
            {
                auditRequest.Type = AuditDataType.Timeout;
                return (null, TimeoutError(), auditData);
            }
            catch (Exception ex)
            {
                auditRequest.Type = AuditDataType.KO;
                return (null, UncontrolledError(ex), auditData);
            }
            finally
            {
                auditData.NumberOfRequests = 1;
                auditRequest.ProcessTime = processTime.ElapsedMilliseconds;
                auditRequest.RQ = rqString;
                auditRequest.RS = responseString;

                auditData.Requests.Add(auditRequest);
            }
        }        

        public async Task<(BookingRS? BookingRS, List<Domain.Error.Error>? Errors, AuditData AuditData)> Booking(ConnectionData connectionData, object query)
        {
            const string c_Method = UrlPath.Booking;
            var rqString = query.SerializeObjectXml();
            var auditData = new AuditData() { Requests = new List<Request>() };
            var auditRequest = new Request() { RequestName = c_Method, TimeStamp = DateTime.UtcNow };
            var responseString = "";
            var processTime = Stopwatch.StartNew(); 

            try
            {
                var client = _httpClientFactory.CreateClient("Av");
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", connectionData.Token);
                client.Timeout = TimeSpan.FromMilliseconds(ServiceConf.TimeoutBooking);

                var separator = connectionData.Url.EndsWith("/") ? "" : "/";

                var uri = new Uri(connectionData.Url);
                client.BaseAddress = uri;

                var message = new HttpRequestMessage(HttpMethod.Post, uri)
                {
                    Content = new StringContent(rqString, Encoding.UTF8, "text/xml")
                };              

                var responseMessage = await client.SendAsync(message, HttpCompletionOption.ResponseHeadersRead);
                responseString = await responseMessage.Content.ReadAsStringAsync();               
               

                if (responseMessage.StatusCode == HttpStatusCode.OK)
                {                   
                    var response = responseString.DeserializeXml<Message.BookingRS.BookingInfoRs>();

                    var errors = new List<Domain.Error.Error>();

                    if (response.Errors != null && response.Errors.Any())
                    {
                        errors.AddRange(CheckError(response.Errors));
                    }

                    if (errors.Any())
                    {
                        auditRequest.Type = AuditDataType.KO;
                        return (null, errors, auditData);
                    }

                    auditRequest.Type = AuditDataType.Ok;
                    return (new BookingRS() { BookingInfoRs = response}, null, auditData);                    
                }
                else
                {
                    //TODO: Implement the error handling
                    var error = new Message.Common.Error() {};
                    auditRequest.Type = AuditDataType.KO;
                    return (null, SupplierError(error), auditData);
                }
            }
            catch (TaskCanceledException)
            {
                auditRequest.Type = AuditDataType.Timeout;
                return (null, TimeoutError(), auditData);
            }
            catch (Exception ex)
            {
                auditRequest.Type = AuditDataType.KO;
                return (null, UncontrolledError(ex), auditData);
            }
            finally
            {
                auditData.NumberOfRequests = 1;
                auditRequest.ProcessTime = processTime.ElapsedMilliseconds;
                auditRequest.RQ = rqString;
                auditRequest.RS = responseString;

                auditData.Requests.Add(auditRequest);
            }
        }

        public async Task<(BookingRS? BookingRS, List<Domain.Error.Error>? Errors, AuditData AuditData)> CancelBooking(ConnectionData connectionData, object query)
        {
            const string c_Method = UrlPath.CancelBooking;
            var processTime = Stopwatch.StartNew();
            var rqString = query.SerializeObjectXml();
            var auditData = new AuditData() { Requests = new List<Request>() };
            var auditRequest = new Request() { RequestName = c_Method, TimeStamp = DateTime.UtcNow };
            var responseString = "";

            try
            {
                var client = _httpClientFactory.CreateClient("Av");
                
                client.Timeout = TimeSpan.FromMilliseconds(ServiceConf.TimeoutBooking);

                var separator = connectionData.Url.EndsWith("/") ? "" : "/";

                var uri = new Uri(connectionData.Url);
                client.BaseAddress = uri;

                var message = new HttpRequestMessage(HttpMethod.Post, uri)
                {
                    Content = new StringContent(rqString, Encoding.UTF8, "text/xml")
                };                

                var responseMessage = await client.SendAsync(message, HttpCompletionOption.ResponseHeadersRead);
                responseString = await responseMessage.Content.ReadAsStringAsync();             

                if (responseMessage.StatusCode == HttpStatusCode.OK)
                {                    
                    var response = responseString.DeserializeXml<Message.BookingRS.BookingInfoRs>();

                    var errors = new List<Domain.Error.Error>();

                    if (response.Errors != null && response.Errors.Any())
                    {
                        errors.AddRange(CheckError(response.Errors));
                    }

                    if (errors.Any())
                    {
                        auditRequest.Type = AuditDataType.KO;
                        return (null, errors, auditData);
                    }

                    auditRequest.Type = AuditDataType.Ok;
                    return (new BookingRS { BookingInfoRs = response}, null, auditData);
                }
                else
                {
                    //TODO: Implement the error handling
                    var error = new Message.Common.Error() {};
                    auditRequest.Type = AuditDataType.KO;
                    return (null, SupplierError(error), auditData);
                }
            }
            catch (TaskCanceledException)
            {
                auditRequest.Type = AuditDataType.Timeout;
                return (null, TimeoutError(), auditData);
            }
            catch (Exception ex)
            {
                auditRequest.Type = AuditDataType.KO;
                return (null, UncontrolledError(ex), auditData);
            }
            finally
            {
                auditData.NumberOfRequests = 1;
                auditRequest.ProcessTime = processTime.ElapsedMilliseconds;
                auditRequest.RQ = rqString;
                auditRequest.RS = responseString;

                auditData.Requests.Add(auditRequest);
            }
        }

        public async Task<(Message.BookingRS.BookingRS? GetBookingRS, List<Domain.Error.Error>? Errors, AuditData AuditData)> GetBookings(ConnectionData connectionData, object query)
        {
            const string c_Method = UrlPath.GetBookings;
            var rqString = query.SerializeObjectXml();
            var auditData = new AuditData() { Requests = new List<Request>() };
            var auditRequest = new Request() { RequestName = c_Method, TimeStamp = DateTime.UtcNow };
            var processTime = Stopwatch.StartNew();
            var responseString = "";

            try
            {
                var client = _httpClientFactory.CreateClient("Av");                
                client.Timeout = TimeSpan.FromMilliseconds(ServiceConf.TimeoutBooking);

                var separator = connectionData.Url.EndsWith("/") ? "" : "/";

                var uri = new Uri(connectionData.Url);
                client.BaseAddress = uri;

                var message = new HttpRequestMessage(HttpMethod.Post, uri)
                {
                    Content = new StringContent(rqString, Encoding.UTF8, "text/xml")
                };                

                var responseMessage = await client.SendAsync(message, HttpCompletionOption.ResponseHeadersRead);
                responseString = await responseMessage.Content.ReadAsStringAsync();

                if (responseMessage.StatusCode == HttpStatusCode.OK)
                {                    
                    var response = responseString.DeserializeXml<Message.BookingRS.BookingInfoRs>();

                    var errors = new List<Domain.Error.Error>();

                    if (response.Errors != null && response.Errors.Any())
                    {
                        errors.AddRange(CheckError(response.Errors));
                    }

                    if (errors.Any())
                    {
                        auditRequest.Type = AuditDataType.KO;
                        return (null, errors, auditData);
                    }

                    auditRequest.Type = AuditDataType.Ok;
                    return (new BookingRS { BookingInfoRs = response}, null, auditData);
                }
                else
                {
                    //TODO: Implement the error handling
                    var error = new Message.Common.Error() {};
                    auditRequest.Type = AuditDataType.KO;
                    return (null, SupplierError(error), auditData);
                }
            }
            catch (TaskCanceledException)
            {
                auditRequest.Type = AuditDataType.Timeout;
                return (null, TimeoutError(), auditData);
            }
            catch (Exception ex)
            {
                auditRequest.Type = AuditDataType.KO;
                return (null, UncontrolledError(ex), auditData);
            }
            finally
            {
                auditData.NumberOfRequests = 1;
                auditRequest.ProcessTime = processTime.ElapsedMilliseconds;
                auditRequest.RQ = rqString;
                auditRequest.RS = responseString;

                auditData.Requests.Add(auditRequest);
            }
        }

       
        private List<Domain.Error.Error> TimeoutError()
        {
            var errors = new List<Domain.Error.Error>
            {
                new Domain.Error.Error(((int)HttpStatusCode.RequestTimeout).ToString(), HttpStatusCode.RequestTimeout.ToString(), ErrorType.Timeout, CategoryErrorType.Provider)
            };
            return errors;
        }
        private List<Domain.Error.Error> TooManyRequests()
        {
            var errors = new List<Domain.Error.Error>
            {
                new Domain.Error.Error(((int)HttpStatusCode.RequestTimeout).ToString(), HttpStatusCode.RequestTimeout.ToString(), ErrorType.Timeout, CategoryErrorType.Provider)
            };
            return errors;
        }

        private List<Domain.Error.Error> UncontrolledError(Exception ex)
        {
            var errors = new List<Domain.Error.Error>
            {
                  new Domain.Error.Error(((int)HttpStatusCode.InternalServerError).ToString(), ex.GetFullMessage(), ErrorType.Error, CategoryErrorType.Hub)
            };
            return errors;
        }

        private List<Domain.Error.Error> SupplierError(Message.Common.Error errorRS)
        {
            //TODO: Implement the error handling
            var errors = new List<Domain.Error.Error>
            {
                new Domain.Error.Error(errorRS.Code, errorRS.Description, ErrorType.Error, CategoryErrorType.Provider)
            };
            return errors;
        }

        private List<Domain.Error.Error> CheckError(List<Message.Common.SupplierErrorRS> errorList)
        {
            //TODO: Implement the error handling
            var errors = new List<Domain.Error.Error> { };
            foreach (var error in errorList)
            {
                var newError = new Domain.Error.Error(((int)ErrorType.Error).ToString(), error.Text, ErrorType.Error, CategoryErrorType.Provider);
                errors.Add(newError);
            }
            return errors;
        }

        private List<Error>? IsEmptyResult(AvailabilityRS? response)
        {
            if (response != null)
            {
               if (response.Hotels.HotelCount > 0)
                    return null;
            }
            return new List<Error> { new Error("NO_AVAIL_FOUND", "No availability found", ErrorType.NoResults, CategoryErrorType.Provider) };
        }

    }
}
