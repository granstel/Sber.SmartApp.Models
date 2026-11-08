using System.Text.Json.Serialization;

namespace Sber.SmartApp.Models
{
    public class Device
    {
        [JsonPropertyName("platformType")]
        public string PlatformType { get; set; }

        [JsonPropertyName("platformVersion")]
        public string PlatformVersion { get; set; }

        [JsonPropertyName("surface")]
        public string Surface { get; set; }

        [JsonPropertyName("surfaceVersion")]
        public string SurfaceVersion { get; set; }

        [JsonPropertyName("deviceId")]
        public string DeviceId { get; set; }

        [JsonPropertyName("deviceManufacturer")]
        public string DeviceManufacturer { get; set; }

        [JsonPropertyName("deviceModel")]
        public string DeviceModel { get; set; }

        [JsonPropertyName("features")]
        public Features Features { get; set; }

        [JsonPropertyName("capabilities")]
        public Capabilities Capabilities { get; set; }
    }
}