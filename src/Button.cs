using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Button
    {
        public string Title { get; set; }

        public Action Action { get; set; }

        public Action[] Actions { get; set; }
    }
}