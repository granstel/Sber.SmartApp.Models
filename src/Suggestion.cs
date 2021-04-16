using Newtonsoft.Json;

namespace Sber.SmartApp.Models
{
    public class Suggestion
    {
        [JsonProperty(PropertyName = "buttons")]
        public Button[] Buttons { get; set; }
    }
}