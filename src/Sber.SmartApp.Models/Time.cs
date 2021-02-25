namespace Sber.SmartApp.Models
{
    public class Time
    {
        public string TimezoneId { get; set; }
        public int TimezoneOffsetSec { get; set; }
        public long Timestamp { get; set; }
    }
}