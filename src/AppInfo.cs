using System;
using System.Text.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class AppInfo
    {
        [JsonPropertyName("projectId")]
        public Guid ProjectId { get; set; }

        [JsonPropertyName("applicationId")]
        public Guid? ApplicationId { get; set; }

        [JsonPropertyName("appversionId")]
        public Guid? AppversionId { get; set; }

        [JsonPropertyName("frontendType")]
        public string FrontendType { get; set; }

        [JsonPropertyName("frontendEndpoint")]
        public string FrontendEndpoint { get; set; }

        [JsonPropertyName("systemName")]
        public string SystemName { get; set; }

        [JsonPropertyName("frontendStateId")]
        public string FrontendStateId { get; set; }
    }
}