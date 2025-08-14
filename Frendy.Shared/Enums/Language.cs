using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Frendy.Shared.Enums;

/// <summary>
/// Перечисление языков
/// </summary>
public enum Language
{
    /// <summary>
    /// Русский
    /// </summary>
    [Display(Name = "ru-ru")]
    Ru = 1,
    
    /// <summary>
    /// Английский
    /// </summary>
    [Display(Name = "en-us")]
    En = 2
}

/// <summary>
/// Расширения для перечисления языков
/// </summary>
public static class LanguageExtensions
{
    /// <summary>
    /// Конвертировать перечисление языка в строковое значение
    /// </summary>
    /// <param name="language">Язык</param>
    /// <returns>Строковое значение языка</returns>
    public static string ToStringValue(this Language language)
    {
        return language.GetType()
            .GetMember(language.ToString())
            .First()
            .GetCustomAttribute<DisplayAttribute>()?
            .Name ?? language.ToString().ToLower();
    }
}