using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Time
    {
        public string TimezoneId { get; set; }

        public int TimezoneOffsetSec { get; set; }

        public long Timestamp { get; set; }
    }
}