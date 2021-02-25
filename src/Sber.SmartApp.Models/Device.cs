namespace Sber.SmartApp.Models
{
    public class Device
    {
        public string PlatformType { get; set; }
        public string PlatformVersion { get; set; }
        public string Surface { get; set; }
        public string SurfaceVersion { get; set; }
        public Features Features { get; set; }
        public Capabilities Capabilities { get; set; }
        public Additionalinfo AdditionalInfo { get; set; }
    }
}