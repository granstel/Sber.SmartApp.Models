using Newtonsoft.Json;
using Sber.SmartApp.Models.Constants;

namespace Sber.SmartApp.Models
{
    public class ResponsePayload
    {
        [JsonProperty(PropertyName = "pronounceText")]
        public string PronounceText { get; set; }

        /// <summary>
        /// Recommend to get values from <see cref="PronounceTextTypes"/>
        /// </summary>
        [JsonProperty(PropertyName = "pronounceTextType")]
        public string PronounceTextType { get; set; }

        [JsonProperty(PropertyName = "emotion")]
        public Emotion Emotion { get; set; }

        [JsonProperty(PropertyName = "items")]
        public PayloadItem[] Items { get; set; }

        [JsonProperty(PropertyName = "suggestions")]
        public Suggestion Suggestions { get; set; }

        [JsonProperty(PropertyName = "auto_listening")]
        public bool AutoListening { get; set; }

        [JsonProperty(PropertyName = "finished")]        
        public bool Finished { get; set; }

        [JsonProperty(PropertyName = "intent")]
        public string Intent { get; set; }

        [JsonProperty(PropertyName = "projectName")]
        public string ProjectName { get; set; }

        [JsonProperty(PropertyName = "device")]
        public Device Device { get; set; }
    }
}