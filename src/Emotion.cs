using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Sber.SmartApp.Models.Constants

namespace Sber.SmartApp.Models
{
    public class Emotion
    {

        /// <summary>
        /// Recommend to get values from <see cref="EmotionIdValues"/>
        /// </summary>
	[JsonProperty(PropertyName = "emotionId")]
        public string EmotionId { get; set; }
    }
}