using Newtonsoft.Json;
using Sber.SmartApp.Models.Constants;

namespace Sber.SmartApp.Models
{
    public class Margins
    {
        /// <summary>
        /// Recommend to get values from <see cref="MarginsValues"/>
        /// </summary>
        [JsonProperty(PropertyName = "top")]
        public string Top { get; set; }

        /// <summary>
        /// Recommend to get values from <see cref="MarginsValues"/>
        /// </summary>
        [JsonProperty(PropertyName = "left")]
        public string Left { get; set; }

        /// <summary>
        /// Recommend to get values from <see cref="MarginsValues"/>
        /// </summary>
        [JsonProperty(PropertyName = "right")]
        public string Right { get; set; }

        /// <summary>
        /// Recommend to get values from <see cref="MarginsValues"/>
        /// </summary>
        [JsonProperty(PropertyName = "bottom")]
        public string Bottom { get; set; }
    }
}