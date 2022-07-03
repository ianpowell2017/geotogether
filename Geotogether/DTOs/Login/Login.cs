using System.Text.Json.Serialization;

namespace Geotogether.DTOs.Login
{
    public record Login
    {
        [JsonPropertyName("identity")]
        public string? Username { get; init; }

        [JsonPropertyName("password")]
        public string? Password { get; init; }
    }
}