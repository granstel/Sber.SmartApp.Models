using Newtonsoft.Json;

namespace Sber.SmartApp.Models
{
    public class Features
    {
        [JsonProperty(PropertyName = "appTypes")]
        public string[] AppTypes { get; set; }
    }
}