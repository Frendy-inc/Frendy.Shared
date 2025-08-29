namespace Frendy.Shared.Dto.RequestDto;

public class UserSearchRequestDto : BaseRequestDto
{
    /// <summary>
    /// Объект с данными для поиска пользователя
    /// </summary>
    public required UserSearchModel UserSearch { get; init; }
}