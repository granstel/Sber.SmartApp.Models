using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Capabilities
    {
        public Capability Screen { get; set; }

        public Capability Mic { get; set; }

        public Capability Speak { get; set; }
    }
}