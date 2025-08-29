using Frendy.Shared.Enums;
using Frendy.Shared.Extensions;
using Frendy.Shared.Helpers;
using Frendy.Shared.Interfaces;
using Frendy.Shared.Models;
using ValidationResult = Frendy.Shared.Models.ValidationResult;

namespace Frendy.Shared.Dto.RequestDto;

/// <summary>
/// Базовый объект для объекта запроса
/// </summary>
public class BaseRequestDto : IRequestModelValidation
{
    /// <summary>
    /// Ссылка возврата
    /// </summary>
    /// <remarks>
    /// По ней будет перенаправлен пользователь после завершения действия
    /// </remarks>
    public string? ReturnUrl { get; set; }
    /// <summary>
    /// Язык локализации
    /// </summary>
    public required Language Language { get; set; }
    
    /// <inheritdoc cref="Shared.Models.DeviceInfo"/>
    public required DeviceInfo DeviceInfo { get; set; }

    public virtual ValidationResult Validate(ILocalizationService localizationService)
    {
        var errors = new List<string>();
        
        if (DeviceInfo.Longitude <= 0 || DeviceInfo.Latitude <= 0)
            errors.Add(localizationService.GetString("IncorrectDeviceCoordinates"));
        
        if (DeviceInfo.Manufacturer.IsNullOrEmpty() || DeviceInfo.Model.IsNullOrEmpty() || DeviceInfo.OperationSystem.IsNullOrEmpty())
            errors.Add(localizationService.GetString("IncorrectDeviceInfo"));
        
        return ValidationHelper.BuildValidationResult(errors);
    }
}