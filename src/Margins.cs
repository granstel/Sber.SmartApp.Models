using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Margins
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