using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Capability
    {
	[JsonProperty(PropertyName = "available")]
        public bool Available { get; set; }
    }
}