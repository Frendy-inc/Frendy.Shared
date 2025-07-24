using System.Text.Json.Serialization;

namespace Frendy.Shared.Models;

public class Address
{
    [JsonPropertyName("shop")]
    public string Shop { get; set; }

    [JsonPropertyName("road")]
    public string Road { get; set; }

    [JsonPropertyName("neighbourhood")]
    public string Neighbourhood { get; set; }

    [JsonPropertyName("suburb")]
    public string Suburb { get; set; }

    [JsonPropertyName("town")]
    public string Town { get; set; }

    [JsonPropertyName("municipality")]
    public string Municipality { get; set; }

    [JsonPropertyName("county")]
    public string County { get; set; }

    [JsonPropertyName("state")]
    public string State { get; set; }

    [JsonPropertyName("region")]
    public string Region { get; set; }
}