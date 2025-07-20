using Frendy.Shared.Enums;

namespace Frendy.Shared.Models;

/// <summary>
/// Объект с результатом валитации
/// </summary>
public class ValidationResult
{
    public ValidationStatus Status { get; set; }
    public List<string>? Errors { get; set; }
}