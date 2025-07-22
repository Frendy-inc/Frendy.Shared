namespace Frendy.Shared.Models.NatsModels;

/// <summary>
/// Модель Nats для авторизации пользователя
/// </summary>
public class NatsLoggedInModel
{
    /// <summary>
    /// Инициализировать модель
    /// </summary>
    /// <param name="town">Город авторизации</param>
    /// <param name="deviceName">Устройство, с которого была совершена авторизация</param>
    /// <param name="loggedInTime">Время авторизации</param>
    /// <param name="activityLogUrl">Ссылка на журнал активности</param>
    public NatsLoggedInModel(string town, string deviceName, DateTime loggedInTime, string activityLogUrl)
    {
        Town = town;
        DeviceName = deviceName;
        LoggedInTime = loggedInTime;
        ActivityLogUrl = activityLogUrl;
    }

    /// <summary>
    /// Город авторизации
    /// </summary>
    public string Town { get; set; }
    
    /// <summary>
    /// Устройство, с которого была совершена авторизация
    /// </summary>
    public string DeviceName { get; set; }
    
    /// <summary>
    /// Время авторизации
    /// </summary>
    public DateTime LoggedInTime { get; set; }
    
    /// <summary>
    /// Ссылка на журнал активности
    /// </summary>
    public string ActivityLogUrl { get; set; }
}