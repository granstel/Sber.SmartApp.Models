using System.Text.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Features
    {
        [JsonPropertyName("appTypes")]
        public string[] AppTypes { get; set; }
    }
}