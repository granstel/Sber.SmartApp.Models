using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Payload
    {
        public AppInfo AppInfo { get; set; }

        public string Intent { get; set; }

        public string OriginalIntent { get; set; }

        public Meta Meta { get; set; }

        [JsonProperty(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
        public string ProjectName { get; set; }

        public Device Device { get; set; }

        public bool NewSession { get; set; }

        public Character Character { get; set; }

        public Strategies Strategies { get; set; }

        public Annotations Annotations { get; set; }

        public Message Message { get; set; }
    }
}