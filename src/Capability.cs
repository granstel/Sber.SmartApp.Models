using Newtonsoft.Json;

namespace Sber.SmartApp.Models
{
    public class Capability
    {
        [JsonProperty(PropertyName = "available")]
        public bool Available { get; set; }
    }
}