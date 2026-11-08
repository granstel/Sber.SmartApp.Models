using System.Text.Json.Serialization;
using Sber.SmartApp.Models.Constants;

namespace Sber.SmartApp.Models
{
    public class CardCellText
    {
        /// <summary>
        /// Recommend to get values from <see cref="CellTypeValues"/>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// Recommend to get values from <see cref="TypefaceValues"/>
        /// </summary>
        [JsonPropertyName("typeface")]
        public string Typeface { get; set; }

        /// <summary>
        /// Recommend to get values from <see cref="TextColorValues"/>
        /// </summary>
        [JsonPropertyName("text_color")]
        public string TextColor { get; set; }

        [JsonPropertyName("max_lines")]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public int? MaxLines { get; set; }

        [JsonPropertyName("margins")]
        public Margins Margins { get; set; }
    }
}
