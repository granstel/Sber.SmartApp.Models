using Newtonsoft.Json;

namespace Sber.SmartApp.Models
{
    public class Annotations
    {
        [JsonProperty(PropertyName = "censor_data")]
        public Annotation CensorData { get; set; }

        [JsonProperty(PropertyName = "text_sentiment")]
        public Annotation TextSentiment { get; set; }

        [JsonProperty(PropertyName = "asr_sentiment")]
        public Annotation AsrSentiment { get; set; }
    }
}