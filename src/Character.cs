using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Character    
    {
	[JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

	[JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

	[JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }

	[JsonProperty(PropertyName = "appeal")]
        public string Appeal { get; set; }
    }
}