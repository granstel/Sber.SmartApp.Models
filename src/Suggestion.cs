using System.Text.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Suggestion
    {
        [JsonPropertyName("buttons")]
        public Button[] Buttons { get; set; }
    }
}