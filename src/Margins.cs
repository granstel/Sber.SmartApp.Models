using System.Text.Json.Serialization;
using Sber.SmartApp.Models.Constants;

namespace Sber.SmartApp.Models
{
    public class Margins
    {
        /// <summary>
        /// Recommend to get values from <see cref="IndentValues"/>
        /// </summary>
        [JsonPropertyName("top")]
        public string Top { get; set; }

        /// <summary>
        /// Recommend to get values from <see cref="IndentValues"/>
        /// </summary>
        [JsonPropertyName("left")]
        public string Left { get; set; }

        /// <summary>
        /// Recommend to get values from <see cref="IndentValues"/>
        /// </summary>
        [JsonPropertyName("right")]
        public string Right { get; set; }

        /// <summary>
        /// Recommend to get values from <see cref="IndentValues"/>
        /// </summary>
        [JsonPropertyName("bottom")]
        public string Bottom { get; set; }
    }
}