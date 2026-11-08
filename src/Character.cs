using System.Text.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Character
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("appeal")]
        public string Appeal { get; set; }
    }
}