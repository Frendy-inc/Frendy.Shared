using System.Globalization;

namespace Frendy.Shared.Interfaces;

/// <summary>
/// Интерфейс сервиса локализации
/// </summary>
public interface ILocalizationService
{
    /// <summary>
    /// Срабатывает, когда настройки локализации меняются
    /// </summary>
    event EventHandler<EventArgs> LocalizationOptionsChanged;

    /// <summary>
    /// Срабатывает, когда текущий язык меняется
    /// </summary>
    event EventHandler<EventArgs> LanguageChanged;

    /// <summary>
    /// Установка текущей культуры
    /// </summary>
    /// <param name="culture">Культура, которая будет установлена как текущая</param>
    Task SetCurrentCultureAsync(CultureInfo culture);

    /// <summary>
    /// Получить поддерживаемые культуры
    /// </summary>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Поддерживаемые культуры</returns>
    ValueTask<IEnumerable<CultureInfo>> GetSupportedCulturesAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Получить локализованную строку
    /// </summary>
    /// <param name="key">Ключ поиска</param>
    /// <returns>Значение локализованной строки</returns>
    string GetString(string key);

    /// <summary>
    /// Получить локализованную строку
    /// </summary>
    /// <param name="key">Ключ поиска</param>
    /// <param name="arguments">Аргументы для постановки</param>
    /// <returns>Значение локализованной строки</returns>
    string GetString(string key, params object[] arguments);

    /// <summary>
    /// Получить локализованную строку в верхнем регистре
    /// </summary>
    /// <param name="key">Ключ поиска</param>
    /// <returns>Значение локализованной строки</returns>
    string GetStringUpper(string key);

    /// <summary>
    /// Получить локализованную строку
    /// </summary>
    /// <param name="key">Ключ поиска</param>
    /// <param name="arguments">Аргументы для постановки</param>
    /// <returns>Значение локализованной строки</returns>
    string GetStringUpper(string key, params object[] arguments);

    /// <summary>
    /// Получить локализованную строку в нижнем регистре
    /// </summary>
    /// <param name="key">Ключ поиска</param>
    /// <returns>Значение локализованной строки</returns>
    string GetStringLower(string key);

    /// <summary>
    /// Получить локализованную строку в нижнем регистре
    /// </summary>
    /// <param name="key">Ключ поиска</param>
    /// <param name="arguments">Аргументы для постановки</param>
    /// <returns>Значение локализованной строки</returns>
    string GetStringLower(string key, params object[] arguments);
}