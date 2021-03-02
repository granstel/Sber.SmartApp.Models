using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Margins
    {
        public string Top { get; set; }

        public string Left { get; set; }

        public string Right { get; set; }

        public string Bottom { get; set; }
    }
}