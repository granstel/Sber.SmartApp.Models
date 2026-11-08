using System.Text.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Uuid
    {
        [JsonPropertyName("userChannel")]
        public string UserChannel { get; set; }

        [JsonPropertyName("sub")]
        public string Sub { get; set; }

        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    }
}