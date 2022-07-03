using System.Text.Json.Serialization;

namespace Geotogether.DTOs.Device
{
    public record ZigbeeStatus
    {
        [JsonPropertyName("electricityClusterStatus")] public string ElectricityClusterStatus { get; set; }
        [JsonPropertyName("gasClusterStatus")] public string GasClusterStatus { get; set; }
        [JsonPropertyName("hanStatus")] public string HanStatus { get; set; }
        [JsonPropertyName("networkRssi")] public int NetworkRssi { get; set; }
    }


}