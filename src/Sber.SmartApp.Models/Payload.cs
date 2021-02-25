namespace Sber.SmartApp.Models
{
    public partial class Payload
    {
        public Device Device { get; set; }

        public AppInfo AppInfo { get; set; }
        public Character Character { get; set; }
        public string Intent { get; set; }
        public string OriginalIntent { get; set; }
        public Meta Meta { get; set; }
        public string ProjectName { get; set; }
        public Annotations Annotations { get; set; }
        public Strategies Strategies { get; set; }
        public Message Message { get; set; }
    }
}