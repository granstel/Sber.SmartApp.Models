using System.Text.Json.Serialization;
using Sber.SmartApp.Models.Constants;

namespace Sber.SmartApp.Models
{
    public class CardCell
    {
        /// <summary>
        /// Recommend to get values from <see cref="CellTypeValues"/>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("top_text")]
        public CardCellText TopText { get; set; }

        [JsonPropertyName("bottom_text")]
        public CardCellText BottomText { get; set; }

        [JsonPropertyName("paddings")]
        public Paddings Paddings { get; set; }

        [JsonPropertyName("actions")]
        public Action[] Actions { get; set; }
    }
}