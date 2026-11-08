using System.Text.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Time
    {
        [JsonPropertyName("timezone_id")]
        public string TimezoneId { get; set; }

        [JsonPropertyName("timezone_offset_sec")]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public int TimezoneOffsetSec { get; set; }

        [JsonPropertyName("timestamp")]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public long Timestamp { get; set; }
    }
}
