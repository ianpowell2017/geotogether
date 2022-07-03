using System.Text.Json.Serialization;

namespace Geotogether.DTOs.Login
{
    public record LoginResponse
    {
        [JsonPropertyName("username")]
        public string? Username { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("validated")]
        public bool Validated { get; set; }

        [JsonPropertyName("accessToken")]
        public string? AccessToken { get; set; }
    }
}