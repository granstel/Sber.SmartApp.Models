using System.Text.Json.Serialization;
using Sber.SmartApp.Models.Constants;

namespace Sber.SmartApp.Models
{
    public class Card
    {
        /// <summary>
        /// Recommend to get values from <see cref="CardTypeValues"/>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("items")]
        public CardCell[] Items { get; set; }

        [JsonPropertyName("columns")]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public int Columns { get; set; }

        /// <summary>
        /// Recommend to get values from <see cref="ItemWidthValues"/>
        /// </summary>
        [JsonPropertyName("item_width")]
        public string ItemWidth { get; set; }
    }
}
