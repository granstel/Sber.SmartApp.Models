using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class AppInfo
    {
        public Guid ProjectId { get; set; }

        public Guid? ApplicationId { get; set; }

        public Guid? AppversionId { get; set; }

        public string FrontendType { get; set; }
    }
}