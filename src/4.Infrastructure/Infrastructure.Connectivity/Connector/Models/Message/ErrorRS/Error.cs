using Newtonsoft.Json;

namespace Infrastructure.Connectivity.Connector.Models.Message.ErrorRS
{
    public class Error
    {
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
