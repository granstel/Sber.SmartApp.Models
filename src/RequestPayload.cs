using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class RequestPayload
    {
	[JsonProperty(PropertyName = "app_info")]
        public AppInfo AppInfo { get; set; }

	[JsonProperty(PropertyName = "intent")]
        public string Intent { get; set; }

	[JsonProperty(PropertyName = "original_intent")]
        public string OriginalIntent { get; set; }

	[JsonProperty(PropertyName = "meta")]
        public Meta Meta { get; set; }

      	[JsonProperty(PropertyName = "projectName")]
        public string ProjectName { get; set; }

	[JsonProperty(PropertyName = "device")]
        public Device Device { get; set; }

	[JsonProperty(PropertyName = "new_session")]
        public bool NewSession { get; set; }

	[JsonProperty(PropertyName = "character")]
        public Character Character { get; set; }

	[JsonProperty(PropertyName = "strategies")]
        public Strategies Strategies { get; set; }

	[JsonProperty(PropertyName = "annotations")]
        public Annotations Annotations { get; set; }

	[JsonProperty(PropertyName = "message")]
        public Message Message { get; set; }
    }
}