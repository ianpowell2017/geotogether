using System.Text.Json.Serialization;

namespace Geotogether.DTOs.DeviceList
{
    public record DeviceListResponse
    {
        [JsonPropertyName("systemRoles")]
        public SystemRole[]? SystemRoles { get; set; }

        [JsonPropertyName("systemDetails")]
        public SystemDetail[]? SystemDetails { get; set; }
    }
}