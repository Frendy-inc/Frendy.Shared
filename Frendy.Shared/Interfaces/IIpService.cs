using Frendy.Shared.Enums;
using Frendy.Shared.Models;

namespace Frendy.Shared.Interfaces;

/// <summary>
/// Описание методов для сервиса получения информации об IP
/// </summary>
public interface IIpService
{
    /// <summary>
    /// Получить информацию по IP-адресу
    /// </summary>
    /// <param name="ipAddress">IP-адрес, о котором нужно получить информацию</param>
    /// <param name="language">Язык локализации</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Информация об IP-адресе</returns>
    public Task<IpInfoResponse> GetIpInfoAsync(string ipAddress, Language language, CancellationToken cancellationToken = default);
}