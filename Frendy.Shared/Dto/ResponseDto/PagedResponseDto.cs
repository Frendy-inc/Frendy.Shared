namespace Frendy.Shared.Dto.ResponseDto;

/// <summary>
/// Унифицированный ответ с пагинацией
/// </summary>
/// <typeparam name="T">Тип элемента</typeparam>
public class PagedResponseDto<T> : BaseResponseDto
{
    public IReadOnlyList<T> Items { get; }
    public int TotalCount { get; }
    public int Page { get; }
    public int PageSize { get; }

    public PagedResponseDto(IReadOnlyList<T> items, int totalCount, int page, int pageSize)
    {
        Items = items;
        TotalCount = totalCount;
        Page = page;
        PageSize = pageSize;
    }
}
