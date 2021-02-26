using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Item
    {
        public Card Card { get; set; }

        public Bubble Bubble { get; set; }
    }
}