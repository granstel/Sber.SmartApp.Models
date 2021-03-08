using System;
using Newtonsoft.Json;

namespace Sber.SmartApp.Models
{
    public class AppInfo
    {
        [JsonProperty(PropertyName = "projectId")]
        public Guid ProjectId { get; set; }

        [JsonProperty(PropertyName = "applicationId")]
        public Guid? ApplicationId { get; set; }

        [JsonProperty(PropertyName = "appversionId")]
        public Guid? AppversionId { get; set; }

        [JsonProperty(PropertyName = "frontendType")]
        public string FrontendType { get; set; }

        [JsonProperty(PropertyName = "frontendEndpoint")]
        public string FrontendEndpoint { get; set; }

        [JsonProperty(PropertyName = "systemName")]
        public string SystemName { get; set; }

        [JsonProperty(PropertyName = "frontendStateId")]
        public string FrontendStateId { get; set; }
    }
}