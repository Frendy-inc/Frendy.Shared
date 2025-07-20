namespace Frendy.Shared.Entities;

/// <summary>
/// Класс градиента
/// </summary>
public class Gradient
{
    /// <summary>
    /// Первый цвет градиента (HEX)
    /// </summary>
    public string FirstColor { get; set; } = null!;
    /// <summary>
    /// Второй цвет градиента (HEX)
    /// </summary>
    /// <remarks>
    /// Если оставить пустым, то будет сплошной цвет
    /// </remarks>
    public string? SecondColor { get; set; }
}