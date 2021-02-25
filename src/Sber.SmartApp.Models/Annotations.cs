﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Annotations
    {
        public Annotation CensorData { get; set; }

        public Annotation TextSentiment { get; set; }

        public Annotation AsrSentiment { get; set; }
    }
}