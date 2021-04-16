using Newtonsoft.Json;
using Sber.SmartApp.Models.Constants;

namespace Sber.SmartApp.Models
{
    public class CardCell
    {
        /// <summary>
        /// Recommend to get values from <see cref="CellTypeValues"/>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "top_text")]
        public CardCellText TopText { get; set; }

        [JsonProperty(PropertyName = "bottom_text")]
        public CardCellText BottomText { get; set; }

        [JsonProperty(PropertyName = "paddings")]
        public Paddings Paddings { get; set; }

        [JsonProperty(PropertyName = "actions")]
        public Action[] Actions { get; set; }
    }
}