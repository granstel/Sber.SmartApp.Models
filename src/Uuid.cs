using Newtonsoft.Json;

namespace Sber.SmartApp.Models
{
    public class Uuid
    {
        [JsonProperty(PropertyName = "userChannel")]
        public string UserChannel { get; set; }

        [JsonProperty(PropertyName = "sub")]
        public string Sub { get; set; }

        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }
    }
}