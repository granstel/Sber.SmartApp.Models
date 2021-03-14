using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Uuid
    {
        public string UserChannel { get; set; }

        public string Sub { get; set; }

        public string UserId { get; set; }
    }
}