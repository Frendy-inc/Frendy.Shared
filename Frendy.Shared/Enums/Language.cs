using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Frendy.Shared.Enums;

public enum Language
{
    [Display(Name = "ru-ru")]
    Ru,
    [Display(Name = "en-us")]
    En
}

public static class LanguageExtensions
{
    public static string ToStringValue(this Language language)
    {
        return language.GetType()
            .GetMember(language.ToString())
            .First()
            .GetCustomAttribute<DisplayAttribute>()?
            .Name ?? language.ToString().ToLower();
    }
}