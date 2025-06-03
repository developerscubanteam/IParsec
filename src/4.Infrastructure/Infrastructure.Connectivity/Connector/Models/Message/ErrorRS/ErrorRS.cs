using Newtonsoft.Json;

namespace Infrastructure.Connectivity.Connector.Models.Message.ErrorRS
{
    public class ErrorRS
    {
        /*[JsonProperty("auditData")]
        public AuditData AuditData { get; set; }*/
        [JsonProperty("error")]
        public Error Error { get; set; }
    }
}
