using Newtonsoft.Json;

namespace Sber.SmartApp.Models
{
    public class Device
    {
        [JsonProperty(PropertyName = "platformType")]
        public string PlatformType { get; set; }

        [JsonProperty(PropertyName = "platformVersion")]
        public string PlatformVersion { get; set; }

        [JsonProperty(PropertyName = "surface")]
        public string Surface { get; set; }

        [JsonProperty(PropertyName = "surfaceVersion")]
        public string SurfaceVersion { get; set; }

        [JsonProperty(PropertyName = "deviceId")]
        public string DeviceId { get; set; }

        [JsonProperty(PropertyName = "deviceManufacturer")]
        public string DeviceManufacturer { get; set; }

        [JsonProperty(PropertyName = "deviceModel")]
        public string DeviceModel { get; set; }

        [JsonProperty(PropertyName = "features")]
        public Features Features { get; set; }

        [JsonProperty(PropertyName = "capabilities")]
        public Capabilities Capabilities { get; set; }
    }
}