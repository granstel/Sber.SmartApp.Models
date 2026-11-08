using System.Text.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Button
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("action")]
        public Action Action { get; set; }

        [JsonPropertyName("actions")]
        public Action[] Actions { get; set; }
    }
}