using Newtonsoft.Json;

namespace Sber.SmartApp.Models
{
    public class Request : ContractBase
    {
        [JsonProperty(PropertyName = "payload")]
        public RequestPayload Payload { get; set; }
    }
}