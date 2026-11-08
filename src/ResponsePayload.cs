using System.Text.Json.Serialization;
using Sber.SmartApp.Models.Constants;

namespace Sber.SmartApp.Models
{
    public class ResponsePayload
    {
        [JsonPropertyName("pronounceText")]
        public string PronounceText { get; set; }

        /// <summary>
        /// Recommend to get values from <see cref="PronounceTextTypeValues"/>
        /// </summary>
        [JsonPropertyName("pronounceTextType")]
        public string PronounceTextType { get; set; }

        [JsonPropertyName("emotion")]
        public Emotion Emotion { get; set; }

        [JsonPropertyName("items")]
        public PayloadItem[] Items { get; set; }

        [JsonPropertyName("suggestions")]
        public Suggestion Suggestions { get; set; }

        [JsonPropertyName("auto_listening")]
        public bool AutoListening { get; set; }

        [JsonPropertyName("finished")]
        public bool Finished { get; set; }

        [JsonPropertyName("intent")]
        public string Intent { get; set; }

        [JsonPropertyName("projectName")]
        public string ProjectName { get; set; }

        [JsonPropertyName("device")]
        public Device Device { get; set; }
    }
}