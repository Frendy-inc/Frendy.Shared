using Frendy.Shared.Enums;
using Frendy.Shared.Helpers;
using Frendy.Shared.Interfaces;
using Frendy.Shared.Models;

namespace Frendy.Shared.Dto.RequestDto.AuthRequestDto;

/// <summary>
/// Объект запроса на подтверждение регистрации
/// </summary>
public class RegisterConfirmRequestDto : BaseRequestDto
{
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public Guid UserId { get; set; }
    
    /// <summary>
    /// Код подтверждения
    /// </summary>
    public required string ConfirmationCode { get; set; }
    
    public override ValidationResult Validate(ILocalizationService localizationService)
    {
        var errors = new List<string>();
        
        if (string.IsNullOrEmpty(ConfirmationCode))
            errors.Add(localizationService.GetString("InvalidConfirmationCode"));
        
        var baseValidationResult = base.Validate(localizationService);
        if (baseValidationResult is { Status: ValidationStatus.Error, Errors.Count: > 0 })
            errors.AddRange(baseValidationResult.Errors);
        
        return ValidationHelper.BuildValidationResult(errors);
    }
}