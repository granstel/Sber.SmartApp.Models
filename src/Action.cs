using System.Text.Json.Serialization;
using Sber.SmartApp.Models.Constants;

namespace Sber.SmartApp.Models
{
    public class Action
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// Recommend to get values from <see cref="ActionTypeValues"/>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("deep_link")]
        public string DeepLink { get; set; }
    }
}