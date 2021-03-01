using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CardItem
    {
        public string Type { get; set; }

        public CardItemText TopText { get; set; }

        public CardItemText BottomText { get; set; }

        public Paddings Paddings { get; set; }

        public Action[] Actions { get; set; }
    }
}