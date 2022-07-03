using System.Text.Json.Serialization;

namespace Geotogether.DTOs.Device
{
    public record SystemStatus
    {
        [JsonPropertyName("component")] public string Component { get; set; }
        [JsonPropertyName("statusType")] public string StatusType { get; set; }
        [JsonPropertyName("systemErrorCode")] public string SystemErrorCode { get; set; }
        [JsonPropertyName("systemErrorNumber")] public int SystemErrorNumber { get; set; }
    }
}