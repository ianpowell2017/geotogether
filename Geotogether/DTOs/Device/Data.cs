using System.Text.Json.Serialization;

namespace Geotogether.DTOs.Device
{
    public record Data
    {
        [JsonPropertyName("latestUtc")] public int LatestUtc { get; set; }
        [JsonPropertyName("id")] public string Id { get; set; }
        [JsonPropertyName("power")] public Power[] Power { get; set; }
        [JsonPropertyName("powerTimestamp")] public int PowerTimestamp { get; set; }
        [JsonPropertyName("localTime")] public int LocalTime { get; set; }
        [JsonPropertyName("localTimeTimestamp")] public int LocalTimeTimestamp { get; set; }
        [JsonPropertyName("creditStatus")] public object CreditStatus { get; set; }
        [JsonPropertyName("creditStatusTimestamp")] public int CreditStatusTimestamp { get; set; }
        [JsonPropertyName("remainingCredit")] public object RemainingCredit { get; set; }
        [JsonPropertyName("remainingCreditTimestamp")] public int RemainingCreditTimestamp { get; set; }
        [JsonPropertyName("zigbeeStatus")] public ZigbeeStatus ZigbeeStatus { get; set; }
        [JsonPropertyName("zigbeeStatusTimestamp")] public int ZigbeeStatusTimestamp { get; set; }
        [JsonPropertyName("emergencyCredit")] public object EmergencyCredit { get; set; }
        [JsonPropertyName("emergencyCreditTimestamp")] public int EmergencyCreditTimestamp { get; set; }
        [JsonPropertyName("systemStatus")] public SystemStatus[] SystemStatus { get; set; }
        [JsonPropertyName("systemStatusTimestamp")] public int SystemStatusTimestamp { get; set; }
        [JsonPropertyName("temperature")] public float Temperature { get; set; }
        [JsonPropertyName("temperatureTimestamp")] public int TemperatureTimestamp { get; set; }
        [JsonPropertyName("ttl")] public int Ttl { get; set; }
    }
}