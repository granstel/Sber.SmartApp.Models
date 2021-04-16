using Newtonsoft.Json;

namespace Sber.SmartApp.Models
{
    public class Meta
    {
        [JsonProperty(PropertyName = "time")]
        public Time Time { get; set; }
    }
}