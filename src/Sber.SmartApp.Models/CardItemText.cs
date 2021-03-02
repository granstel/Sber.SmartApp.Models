using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CardItemText
    {
        public string Type { get; set; }

        public string Text { get; set; }

        public string Typeface { get; set; }

        public string TextColor { get; set; }

        public int? MaxLines { get; set; }

        public Margins Margins { get; set; }
    }
}