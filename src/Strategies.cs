using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Strategies
    {
	[JsonProperty(PropertyName = "happy_birthday")]
        public bool HappyBirthday { get; set; }

	[JsonProperty(PropertyName = "last_call")]
        public long? LastCall { get; set; }
        
	[JsonProperty(PropertyName = "is_alice")]
        public bool IsAlice { get; set; }
    }
}