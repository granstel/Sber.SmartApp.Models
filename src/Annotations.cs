using System.Text.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Annotations
    {
        [JsonPropertyName("censor_data")]
        public Annotation CensorData { get; set; }

        [JsonPropertyName("text_sentiment")]
        public Annotation TextSentiment { get; set; }

        [JsonPropertyName("asr_sentiment")]
        public Annotation AsrSentiment { get; set; }
    }
}