using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Margins
    {
        public string Top { get; set; }
    }
}