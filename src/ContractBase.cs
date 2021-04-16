using Newtonsoft.Json;
using Sber.SmartApp.Models.Constants;

namespace Sber.SmartApp.Models
{
    public abstract class ContractBase
    {
        /// <summary>
        /// Recommend to get values from <see cref="MessageNameValues"/>
        /// </summary>
        [JsonProperty(PropertyName = "messageName")]
        public string MessageName { get; set; }

        [JsonProperty(PropertyName = "sessionId")]
        public string SessionId { get; set; }

        [JsonProperty(PropertyName = "messageId")]
        public long MessageId { get; set; }

        [JsonProperty(PropertyName = "uuid")]
        public Uuid Uuid { get; set; }
    }
}
