using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class PayloadItem
    {
        public PayloadItem()
        {
            Card = new Card();
            Bubble = new Bubble();
        }

        public Bubble Bubble { get; set; }

        public Card Card { get; set; }
    }
}