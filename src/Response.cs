using Newtonsoft.Json;

namespace Sber.SmartApp.Models
{
    public class Response : ContractBase
    {
        [JsonProperty(PropertyName = "payload")]
        public ResponsePayload Payload { get; set; }
    }
}