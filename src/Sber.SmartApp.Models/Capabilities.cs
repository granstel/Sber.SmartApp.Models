using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Capabilities
    {
        public Capabilitiy Screen { get; set; }

        public Capabilitiy Mic { get; set; }

        public Capabilitiy Speak { get; set; }
    }
}