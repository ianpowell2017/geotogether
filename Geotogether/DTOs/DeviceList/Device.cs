using System.Text.Json.Serialization;

namespace Geotogether.DTOs.DeviceList
{
    public record Device
    {
        [JsonPropertyName(name: "deviceType")]
        public string? DeviceType { get; set; }

        [JsonPropertyName("sensorType")]
        public int SensorType { get; set; }

        [JsonPropertyName("nodeId")]
        public int NodeId { get; set; }

        [JsonPropertyName("versionNumber")]
        public VersionNumber? VersionNumber { get; set; }

        [JsonPropertyName("pairedTimestamp")]
        public int PairedTimestamp { get; set; }

        [JsonPropertyName("pairingCode")]
        public string? PairingCode { get; set; }

        [JsonPropertyName("upgradeRequired")]
        public bool UpgradeRequired { get; set; }
    }
}