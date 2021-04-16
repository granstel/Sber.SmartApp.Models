using Newtonsoft.Json;
using Sber.SmartApp.Models.Constants;

namespace Sber.SmartApp.Models
{
    public class Action
    {
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Recommend to get values from <see cref="ActionTypeValues"/>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "deep_link")]
        public string DeepLink { get; set; }
    }
}