using Frendy.Shared.Enums;
using Frendy.Shared.Helpers;
using Frendy.Shared.Interfaces;
using Frendy.Shared.Models;

namespace Frendy.Shared.Dto.RequestDto.AuthRequestDto;

/// <summary>
/// Объект запроса на подтверждение регистрации
/// </summary>
public class PasswordResetConfirmRequestDto : BaseRequestDto
{
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public Guid UserId { get; set; }
    
    /// <summary>
    /// Код подтверждения
    /// </summary>
    public required string ConfirmationCode { get; set; }
    
    /// <summary>
    /// Пароль
    /// </summary>
    public required string Password { get; set; }
    
    /// <summary>
    /// Повтор пароля
    /// </summary>
    public required string ConfirmPassword { get; set; }
    
    public override ValidationResult Validate(ILocalizationService localizationService)
    {
        var errors = new List<string>();
            
        if (!ValidationHelper.ValidatePassword(Password))
            errors.Add(localizationService.GetString("IncorrectPassword"));
        
        if (!string.Equals(Password, ConfirmPassword))
            errors.Add(localizationService.GetString("PasswordsDontMatch"));
        
        var baseValidationResult = base.Validate(localizationService);
        if (baseValidationResult is { Status: ValidationStatus.Error, Errors.Count: > 0 })
            errors.AddRange(baseValidationResult.Errors);
        
        return ValidationHelper.BuildValidationResult(errors);
    }
}