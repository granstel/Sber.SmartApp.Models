using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Card
    {
        public string Type { get; set; }

        public CardItem[] Items { get; set; }

        public int Columns { get; set; }

        public string ItemWidth { get; set; }
    }
}