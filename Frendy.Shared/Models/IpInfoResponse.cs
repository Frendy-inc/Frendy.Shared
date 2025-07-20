using Newtonsoft.Json;

namespace Frendy.Shared.Models;

/// <summary>
/// Модель для десериализации ответа ipstack API
/// </summary>
public class IpInfoResponse
{
    public string Ip { get; set; }
    
    public string City { get; set; }
    
    [JsonProperty("region_name")]
    public string RegionName { get; set; }
    
    [JsonProperty("country_name")]
    public string CountryName { get; set; }
    
    public string Latitude { get; set; }
    
    public string Longitude { get; set; }
    
    public string Zip { get; set; }
}