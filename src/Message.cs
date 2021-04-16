using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Message
    {
	[JsonProperty(PropertyName = "original_text")]
        public string OriginalText { get; set; }

	[JsonProperty(PropertyName = "normalized_text")]
        public string NormalizedText { get; set; }

	[JsonProperty(PropertyName = "asr_normalized_message")]
        public string AsrNormalizedMessage { get; set; }
    }
}