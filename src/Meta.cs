using System.Text.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Meta
    {
        [JsonPropertyName("time")]
        public Time Time { get; set; }
    }
}