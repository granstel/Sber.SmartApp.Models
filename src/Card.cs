using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Card
    {
	[JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

	[JsonProperty(PropertyName = "items")]
        public CardItem[] Items { get; set; }

	[JsonProperty(PropertyName = "columns")]
        public int Columns { get; set; }

	[JsonProperty(PropertyName = "item_width")]
        public string ItemWidth { get; set; }
    }
}