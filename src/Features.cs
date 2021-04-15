using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Features
    {
	[JsonProperty(PropertyName = "appTypes")]
        public string[] AppTypes { get; set; }
    }
}