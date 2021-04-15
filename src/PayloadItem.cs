using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class PayloadItem
    {
        public PayloadItem()
        {
            Card = new Card();
            Bubble = new Bubble();
        }

	[JsonProperty(PropertyName = "bubble")]
        public Bubble Bubble { get; set; }

	[JsonProperty(PropertyName = "card")]
        public Card Card { get; set; }
    }
}