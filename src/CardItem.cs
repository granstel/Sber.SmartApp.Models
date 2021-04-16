using Newtonsoft.Json;
using Sber.SmartApp.Models.Constants;

namespace Sber.SmartApp.Models
{
    public class CardItem
    {
        /// <summary>
        /// Recommend to get values from <see cref="ItemsTypeValues"/>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "top_text")]
        public CardItemText TopText { get; set; }

        [JsonProperty(PropertyName = "bottom_text")]
        public CardItemText BottomText { get; set; }

        [JsonProperty(PropertyName = "paddings")]
        public Paddings Paddings { get; set; }

        [JsonProperty(PropertyName = "actions")]
        public Action[] Actions { get; set; }
    }
}