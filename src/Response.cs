using System.Text.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Response : ContractBase
    {
        [JsonPropertyName("payload")]
        public ResponsePayload Payload { get; set; }
    }
}