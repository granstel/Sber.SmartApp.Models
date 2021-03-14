using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Message
    {
        public string OriginalText { get; set; }

        public string NormalizedText { get; set; }

        public string AsrNormalizedMessage { get; set; }
    }
}