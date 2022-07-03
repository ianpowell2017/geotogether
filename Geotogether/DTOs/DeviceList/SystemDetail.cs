using System.Text.Json.Serialization;

namespace Geotogether.DTOs.DeviceList
{
    public record SystemDetail
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("devices")]
        public Device[]? Devices { get; set; }

        [JsonPropertyName("systemId")]
        public string? SystemId { get; set; }
    }
}