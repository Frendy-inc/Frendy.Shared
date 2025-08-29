using Frendy.Shared.Enums;
using Frendy.Shared.Extensions;
using Frendy.Shared.Helpers;
using Frendy.Shared.Interfaces;
using Frendy.Shared.Models;

namespace Frendy.Shared.Dto.RequestDto.AuthRequestDto;

/// <summary>
/// Запрос на повторную отправку сообщения подтверждения
/// </summary>
public class ResendConfirmMessageRequestDto : UserSearchRequestDto
{
    /// <summary>
    /// Тип подтверждения
    /// </summary>
    public ConfirmType ConfirmType { get; set; }
    
    public override ValidationResult Validate(ILocalizationService localizationService)
    {
        var errors = new List<string>();
        
        if (UserSearch.SearchMode == UserSearchMode.UserName)
            errors.Add(localizationService.GetString("IncorrectUserSearchMode", UserSearch.SearchMode.GetEnumName()));
        
        if (UserSearch.SearchMode == UserSearchMode.Email && !UserSearch.SearchValue.IsNullOrEmpty() 
                && !ValidationHelper.ValidateEmail(UserSearch.SearchValue))
            errors.Add(localizationService.GetString("IncorrectEmailFormat"));
        
        if (UserSearch.SearchMode == UserSearchMode.PhoneNumber && !UserSearch.SearchValue.IsNullOrEmpty() 
                && !ValidationHelper.ValidatePhoneNumber(UserSearch.SearchValue))
            errors.Add(localizationService.GetString("IncorrectPhoneNumberFormat"));
        
        var baseValidationResult = base.Validate(localizationService);
        if (baseValidationResult is { Status: ValidationStatus.Error, Errors.Count: > 0 })
            errors.AddRange(baseValidationResult.Errors);
        
        return ValidationHelper.BuildValidationResult(errors);
    }
}