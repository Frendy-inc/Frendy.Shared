using Frendy.Shared.Enums;
using Frendy.Shared.Helpers;
using Frendy.Shared.Interfaces;
using Frendy.Shared.Models;

namespace Frendy.Shared.Dto.RequestDto.UserRequestDto;

/// <summary>
/// Объект для получения пользователя по Email/номеру телефона
/// </summary>
public class GetUserRequestDto : BaseRequestDto
{
    /// <inheritdoc cref="UserSearchModel"/>
    public required UserSearchModel UserSearch { get; init; } 
    
    public override ValidationResult Validate(ILocalizationService localizationService)
    {
        var errors = new List<string>();
        
        var validationResult = UserSearch.Validate(localizationService);
        if (validationResult is { Status: ValidationStatus.Error, Errors.Count: > 0 })
            errors.AddRange(validationResult.Errors);
        
        var baseValidationResult = base.Validate(localizationService);
        if (baseValidationResult is { Status: ValidationStatus.Error, Errors.Count: > 0 })
            errors.AddRange(baseValidationResult.Errors);
        
        return ValidationHelper.BuildValidationResult(errors);
    }
}