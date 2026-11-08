using System.Text.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Message
    {
        [JsonPropertyName("original_text")]
        public string OriginalText { get; set; }

        [JsonPropertyName("normalized_text")]
        public string NormalizedText { get; set; }

        [JsonPropertyName("asr_normalized_message")]
        public string AsrNormalizedMessage { get; set; }
    }
}