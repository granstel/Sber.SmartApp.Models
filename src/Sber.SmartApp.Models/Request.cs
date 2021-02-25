using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Request
    {
        public string MessageName { get; set; }

        public string SessionId { get; set; }

        public long MessageId { get; set; }

        public Uuid Uuid { get; set; }

        public Payload Payload { get; set; }
    }
}