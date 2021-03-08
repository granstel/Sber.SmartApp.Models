using Newtonsoft.Json;

namespace Sber.SmartApp.Models
{
    public class Action
    {
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "deep_link")]
        public string DeepLink { get; set; }
    }
}