using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{   
    public class Capabilities
    {
	[JsonProperty(PropertyName = "screen")]
        public Capability Screen { get; set; }

	[JsonProperty(PropertyName = "mic")]
        public Capability Mic { get; set; }

	[JsonProperty(PropertyName = "speak")]
        public Capability Speak { get; set; }
    }
}