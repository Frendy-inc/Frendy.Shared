using Frendy.Shared.Enums;

namespace Frendy.Shared.Dto;

/// <summary>
/// Объект, содержащий информацию по режиму поиска пользователя
/// </summary>
public class UserSearchModel
{
    /// <summary>
    /// Значение для поиска
    /// </summary>
    public required string SearchValue { get; init; }

    /// <inheritdoc cref="UserSearchMode"/>
    public required UserSearchMode SearchMode { get; init; }
}