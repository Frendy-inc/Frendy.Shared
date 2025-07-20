namespace Frendy.Shared.Extensions;

/// <summary>
/// Расширения конвертации
/// </summary>
public static class ConvertExtension
{
    /// <summary>
    /// Получить имя перечисления
    /// </summary>
    /// <param name="inputEnum">Перечисление, имя которого нужно получить</param>
    /// <typeparam name="T">Тип перечисления</typeparam>
    /// <returns>Название перечисления</returns>
    /// <exception cref="ArgumentException"></exception>
    public static string GetEnumName<T>(this T inputEnum) where T : Enum
    {
        var enumName = Enum.GetName(typeof(T), inputEnum);
        return enumName ?? throw new ArgumentException($"The value '{inputEnum}' not found in enum '{nameof(T)}'");
    }
}