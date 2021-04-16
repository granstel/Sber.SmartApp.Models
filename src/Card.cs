using Newtonsoft.Json;
using Sber.SmartApp.Models.Constants;

namespace Sber.SmartApp.Models
{
    public class Card
    {
        /// <summary>
        /// Recommend to get values from <see cref="CardTypeValues"/>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "items")]
        public CardItem[] Items { get; set; }

        [JsonProperty(PropertyName = "columns")]
        public int Columns { get; set; }

        /// <summary>
        /// Recommend to get values from <see cref="ItemWidthValues"/>
        /// </summary>
        [JsonProperty(PropertyName = "item_width")]
        public string ItemWidth { get; set; }
    }
}