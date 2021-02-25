using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Strategies
    {
        public bool HappyBirthday { get; set; }

        public long LastCall { get; set; }
        
        public bool IsAlice { get; set; }
    }
}