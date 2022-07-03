using System.Text.Json.Serialization;

namespace Geotogether.DTOs.DeviceList
{
    public record VersionNumber
    {
        [JsonPropertyName("major")]
        public int Major { get; set; }

        [JsonPropertyName("minor")]
        public int Minor { get; set; }
    }
}