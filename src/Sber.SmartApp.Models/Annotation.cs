using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Annotation
    {
        public string[] Classes { get; set; }

        public float[] Probas { get; set; }
    }
}