using System.Text.Json.Serialization;

namespace Frendy.Shared.Models;

public class LocationInfo
{
    [JsonPropertyName("place_id")]
    public long PlaceId { get; set; }

    [JsonPropertyName("osm_type")]
    public string OsmType { get; set; }

    [JsonPropertyName("osm_id")]
    public long OsmId { get; set; }

    [JsonPropertyName("lat")]
    public string Latitude { get; set; }

    [JsonPropertyName("lon")]
    public string Longitude { get; set; }

    [JsonPropertyName("category")]
    public string Category { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("place_rank")]
    public int PlaceRank { get; set; }

    [JsonPropertyName("importance")]
    public double Importance { get; set; }

    [JsonPropertyName("addresstype")]
    public string AddressType { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("display_name")]
    public string DisplayName { get; set; }

    [JsonPropertyName("address")]
    public Address Address { get; set; }

    [JsonPropertyName("boundingbox")]
    public List<string> BoundingBox { get; set; }
}