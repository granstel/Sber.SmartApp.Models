using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Request : ContractBase
    {
	[JsonProperty(PropertyName = "payload")]
        public RequestPayload Payload { get; set; }
    }
}