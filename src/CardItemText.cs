using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class CardItemText
    {
	[JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

	[JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

	[JsonProperty(PropertyName = "typeface")]
        public string Typeface { get; set; }

	[JsonProperty(PropertyName = "text_color")]
        public string TextColor { get; set; }

	[JsonProperty(PropertyName = "max_lines")]
        public int? MaxLines { get; set; }

	[JsonProperty(PropertyName = "margins")]
        public Margins Margins { get; set; }
    }
}