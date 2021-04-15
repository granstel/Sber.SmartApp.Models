using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Emotion
    {
	[JsonProperty(PropertyName = "emotionId")]
        public string EmotionId { get; set; }
    }
}