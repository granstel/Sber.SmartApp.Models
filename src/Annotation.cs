using System.Text.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Annotation
    {
        [JsonPropertyName("classes")]
        public string[] Classes { get; set; }

        [JsonPropertyName("probas")]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public float[] Probas { get; set; }
    }
}
