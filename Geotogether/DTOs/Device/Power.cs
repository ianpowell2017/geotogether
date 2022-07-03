using System.Text.Json.Serialization;

namespace Geotogether.DTOs.Device
{
    public record Power
    {
        [JsonPropertyName("type")] public string Type { get; set; }
        [JsonPropertyName("watts")] public int Watts { get; set; }
        [JsonPropertyName("valueAvailable")] public bool ValueAvailable { get; set; }
    }
}