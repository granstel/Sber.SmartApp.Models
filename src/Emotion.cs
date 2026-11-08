using System.Text.Json.Serialization;
using Sber.SmartApp.Models.Constants;

namespace Sber.SmartApp.Models
{
    public class Emotion
    {
        /// <summary>
        /// Recommend to get values from <see cref="EmotionIdValues"/>
        /// </summary>
        [JsonPropertyName("emotionId")]
        public string EmotionId { get; set; }
    }
}