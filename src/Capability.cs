using System.Text.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Capability
    {
        [JsonPropertyName("available")]
        public bool Available { get; set; }
    }
}