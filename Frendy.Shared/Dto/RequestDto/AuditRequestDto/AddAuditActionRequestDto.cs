namespace Frendy.Shared.Dto.RequestDto.AuditRequestDto;

/// <summary>
/// Dto для добавления нового действия аудита
/// </summary>
public class AddAuditActionRequestDto
{
    /// <summary>
    /// Название на русском
    /// </summary>
    public string NameRu { get; set; } = null!;
    
    /// <summary>
    /// Название на английском
    /// </summary>
    public string NameEn { get; set; } = null!;
}