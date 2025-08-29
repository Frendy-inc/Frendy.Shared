namespace Frendy.Shared.Dto.ResponseDto.ActionResponseDto;

/// <summary>
/// DTO действия аудита
/// </summary>
public class ActionDto
{
    public int Id { get; set; }
    public string NameRu { get; set; } = null!;
    public string NameEn { get; set; } = null!;
}
