using System.Text.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Capabilities
    {
        [JsonPropertyName("screen")]
        public Capability Screen { get; set; }

        [JsonPropertyName("mic")]
        public Capability Mic { get; set; }

        [JsonPropertyName("speak")]
        public Capability Speak { get; set; }
    }
}