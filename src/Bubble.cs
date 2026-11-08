using System.Text.Json.Serialization;
using Sber.SmartApp.Models.Constants;

namespace Sber.SmartApp.Models
{
    public class Bubble
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("markdown")]
        public bool Markdown { get; set; }

        /// <summary>
        /// Recommend to get values from <see cref="ExpandPolicyValues"/>
        /// </summary>
        [JsonPropertyName("expand_policy")]
        public string ExpandPolicy { get; set; }
    }
}