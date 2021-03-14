using Newtonsoft.Json;

namespace Sber.SmartApp.Models
{
    public class Annotation
    {
        [JsonProperty(PropertyName = "classes")]
        public string[] Classes { get; set; }

        [JsonProperty(PropertyName = "probas")]
        public float[] Probas { get; set; }
    }
}