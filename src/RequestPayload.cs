using System.Text.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class RequestPayload
    {
        [JsonPropertyName("app_info")]
        public AppInfo AppInfo { get; set; }

        [JsonPropertyName("intent")]
        public string Intent { get; set; }

        [JsonPropertyName("original_intent")]
        public string OriginalIntent { get; set; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }

        [JsonPropertyName("projectName")]
        public string ProjectName { get; set; }

        [JsonPropertyName("device")]
        public Device Device { get; set; }

        [JsonPropertyName("new_session")]
        public bool NewSession { get; set; }

        [JsonPropertyName("character")]
        public Character Character { get; set; }

        [JsonPropertyName("strategies")]
        public Strategies Strategies { get; set; }

        [JsonPropertyName("annotations")]
        public Annotations Annotations { get; set; }

        [JsonPropertyName("message")]
        public Message Message { get; set; }
    }
}
