using System.Text.Json.Serialization;
using Sber.SmartApp.Models.Constants;

namespace Sber.SmartApp.Models
{
    [JsonDerivedType(typeof(Request))]
    [JsonDerivedType(typeof(Response))]
    public abstract class ContractBase
    {
        /// <summary>
        /// Recommend to get values from <see cref="MessageNameValues"/>
        /// </summary>
        [JsonPropertyName("messageName")]
        public string MessageName { get; set; }

        [JsonPropertyName("sessionId")]
        public string SessionId { get; set; }

        [JsonPropertyName("messageId")]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public long MessageId { get; set; }

        [JsonPropertyName("uuid")]
        public Uuid Uuid { get; set; }
    }
}
