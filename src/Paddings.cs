using Newtonsoft.Json;

namespace Sber.SmartApp.Models
{
    public class Paddings
    {
        [JsonProperty(PropertyName = "top")]
        public string Top { get; set; }

        [JsonProperty(PropertyName = "left")]
        public string Left { get; set; }

        [JsonProperty(PropertyName = "right")]
        public string Right { get; set; }

        [JsonProperty(PropertyName = "bottom")]
        public string Bottom { get; set; }
    }
}