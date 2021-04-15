using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public abstract class ContractBase
    {
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
