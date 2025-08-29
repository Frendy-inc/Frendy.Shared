using Frendy.Shared.Enums;
using Frendy.Shared.Extensions;
using Frendy.Shared.Helpers;
using Frendy.Shared.Interfaces;
using Frendy.Shared.Models;

namespace Frendy.Shared.Dto.RequestDto.AuthRequestDto;

/// <summary>
/// Объект запроса на смену пароля
/// </summary>
public class PasswordResetRequestDto : UserSearchRequestDto
{
    public override ValidationResult Validate(ILocalizationService localizationService)
    {
        var errors = new List<string>();

        var userSearchValidationResult = UserSearch.Validate(localizationService);
        
        if (userSearchValidationResult is { Status: ValidationStatus.Error, Errors.Count: > 0 })
            errors.AddRange(userSearchValidationResult.Errors);
        
        if (UserSearch.SearchMode == UserSearchMode.Email)
            if (!ValidationHelper.ValidateEmail(UserSearch.SearchValue))
                errors.Add(localizationService.GetString("IncorrectEmailFormat"));
        
        if (UserSearch.SearchMode == UserSearchMode.PhoneNumber)
            if (!ValidationHelper.ValidatePhoneNumber(UserSearch.SearchValue))
                errors.Add(localizationService.GetString("IncorrectPhoneNumberFormat"));
        
        if (UserSearch.SearchMode == UserSearchMode.UserName)
            errors.Add(localizationService.GetString("IncorrectUserSearchMode", UserSearch.SearchMode.GetEnumName()));
        
        var baseValidationResult = base.Validate(localizationService);
        if (baseValidationResult is { Status: ValidationStatus.Error, Errors.Count: > 0 })
            errors.AddRange(baseValidationResult.Errors);
        
        return ValidationHelper.BuildValidationResult(errors);
    }
}