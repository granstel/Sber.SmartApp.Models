using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{    
    public class Button
    {
	[JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

	[JsonProperty(PropertyName = "action")]
        public Action Action { get; set; }

	[JsonProperty(PropertyName = "actions")]
        public Action[] Actions { get; set; }
    }
}