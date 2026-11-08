using System.Text.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class PayloadItem
    {
        public PayloadItem()
        {
            Card = new Card();
            Bubble = new Bubble();
        }

        [JsonPropertyName("bubble")]
        public Bubble Bubble { get; set; }

        [JsonPropertyName("card")]
        public Card Card { get; set; }
    }
}