using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Response : ContractBase
    {
	[JsonProperty(PropertyName = "payload")]
        public ResponsePayload Payload { get; set; }
    }
}