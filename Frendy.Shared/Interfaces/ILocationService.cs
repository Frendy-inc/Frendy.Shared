using Frendy.Shared.Enums;
using Frendy.Shared.Exceptions;
using Frendy.Shared.Models;

namespace Frendy.Shared.Interfaces;

/// <summary>
/// Описание методов сервиса информации о локациях
/// </summary>
public interface ILocationService
{
    /// <summary>
    /// Получить информацию о текущей локации
    /// </summary>
    /// <param name="latitude">Текущая широта</param>
    /// <param name="longitude">Текущая долгота</param>
    /// <param name="language">Язык локализации</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <exception cref="InternalException">Внуренняя ошибка</exception>
    /// <returns>Идентификатор города</returns>
    public Task<LocationInfo> GetLocationInfoByCoordinatesAsync(double latitude, double longitude, Language language, CancellationToken cancellationToken = default);
}