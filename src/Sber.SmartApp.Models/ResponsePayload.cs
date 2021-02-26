using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ResponsePayload
    {
        public string PronounceText { get; set; }

        public string PronounceTextType { get; set; }

        public Emotion Emotion { get; set; }

        public Item[] Items { get; set; }

        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public bool AutoListening { get; set; }
        
        public bool Finished { get; set; }

        public string Intent { get; set; }

        public string ProjectName { get; set; }

        public Device Device { get; set; }
    }
}