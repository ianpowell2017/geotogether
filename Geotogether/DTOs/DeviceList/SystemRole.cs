using System.Text.Json.Serialization;

namespace Geotogether.DTOs.DeviceList
{
    public record SystemRole
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("systemId")]
        public string? SystemId { get; set; }

        [JsonPropertyName("roles")]
        public string[]? Roles { get; set; }
    }
}