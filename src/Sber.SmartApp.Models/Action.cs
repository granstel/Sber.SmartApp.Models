using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Action
    {
        public string Text { get; set; }

        public string Type { get; set; }

        public string DeepLink { get; set; }
    }
}