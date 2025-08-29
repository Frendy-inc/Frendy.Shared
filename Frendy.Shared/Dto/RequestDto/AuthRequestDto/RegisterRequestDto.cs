using Frendy.Shared.Enums;
using Frendy.Shared.Extensions;
using Frendy.Shared.Helpers;
using Frendy.Shared.Interfaces;
using Frendy.Shared.Models;

namespace Frendy.Shared.Dto.RequestDto.AuthRequestDto;

/// <summary>
/// Объект запроса на регистрацию
/// </summary>
public class RegisterRequestDto : UserSearchRequestDto
{
    /// <summary>
    /// Пароль
    /// </summary>
    public string? Password { get; set; }
    /// <summary>
    /// Повтор пароля
    /// </summary>
    public string? ConfirmPassword { get; set; }
    
    public override ValidationResult Validate(ILocalizationService localizationService)
    {
        var errors = new List<string>();

        var userSearchValidationResult = UserSearch.Validate(localizationService);
        
        if (userSearchValidationResult is { Status: ValidationStatus.Error, Errors.Count: > 0 })
            errors.AddRange(userSearchValidationResult.Errors);
        
        if (UserSearch.SearchMode == UserSearchMode.Email && !Password.IsNullOrEmpty())
        {
            if (!ValidationHelper.ValidateEmail(UserSearch.SearchValue))
                errors.Add(localizationService.GetString("IncorrectEmailFormat"));
            
            if (!ValidationHelper.ValidatePassword(Password!))
                errors.Add(localizationService.GetString("IncorrectPassword"));
            
            if (!string.Equals(Password, ConfirmPassword))
                errors.Add(localizationService.GetString("PasswordsDontMatch"));
        }
        
        if (UserSearch.SearchMode == UserSearchMode.PhoneNumber && Password.IsNullOrEmpty())
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