using Newtonsoft.Json;
using Sber.SmartApp.Models.Constants;

namespace Sber.SmartApp.Models
{
    public class Bubble
    {
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        
        [JsonProperty(PropertyName = "markdown")]
        public bool Markdown { get; set; }

        /// <summary>
        /// Recommend to get values from <see cref="ExpandPolicies"/>
        /// </summary>
        [JsonProperty(PropertyName = "expand_policy")]
        public string ExpandPolicy { get; set; }
    }
}