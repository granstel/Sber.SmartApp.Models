using System.Text.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Strategies
    {
        [JsonPropertyName("happy_birthday")]
        public bool HappyBirthday { get; set; }

        [JsonPropertyName("last_call")]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public long? LastCall { get; set; }

        [JsonPropertyName("is_alice")]
        public bool IsAlice { get; set; }
    }
}
