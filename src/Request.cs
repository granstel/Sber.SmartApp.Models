using System.Text.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Request : ContractBase
    {
        [JsonPropertyName("payload")]
        public RequestPayload Payload { get; set; }
    }
}