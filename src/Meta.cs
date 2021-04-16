using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Meta
    {
	[JsonProperty(PropertyName = "time")]
        public Time Time { get; set; }
    }
}