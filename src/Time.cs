using Newtonsoft.Json;

namespace Sber.SmartApp.Models
{
    public class Time
    {
        [JsonProperty(PropertyName = "timezone_id")]
        public string TimezoneId { get; set; }

        [JsonProperty(PropertyName = "timezone_offset_sec")]
        public int TimezoneOffsetSec { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        public long Timestamp { get; set; }
    }
}