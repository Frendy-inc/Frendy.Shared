using System.ComponentModel.DataAnnotations;

namespace Frendy.Shared.Models;

/// <summary>
/// Объект информации об устройстве
/// </summary>
public class DeviceInfo
{
    /// <summary>
    /// Производитель устройства, с которого пришёл запрос
    /// </summary>
    public required string Manufacturer { get; set; }

    /// <summary>
    /// Модель устройства, с которого пришёл запрос
    /// </summary>
    public required string Model { get; set; }

    /// <summary>
    /// Ip адрес устройства
    /// </summary>
    public required string IpAddress { get; set; }
    
    /// <summary>
    /// Операционная система
    /// </summary>
    public required string OperationSystem { get; set; }
    
    /// <summary>
    /// Широта
    /// </summary>
    public required double Latitude { get; set; }
    
    /// <summary>
    /// Долгота
    /// </summary>
    public required double Longitude { get; set; }

    /// <summary>
    /// Получить полное название утройства
    /// </summary>
    public string GetDeviceName()
    {
        return $"{Manufacturer} {Model}";
    }
}