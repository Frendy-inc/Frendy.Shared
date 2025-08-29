using Frendy.Shared.Models;

namespace Frendy.Shared.Interfaces;

/// <summary>
/// Интерфейс, описывающий метод валидации модели запроса
/// </summary>
public interface IRequestModelValidation
{
    /// <summary>
    /// Провести валидацию модели
    /// </summary>
    /// <param name="localizationService">Сервис локализации</param>
    /// <returns>Результат валидации</returns>
    ValidationResult Validate(ILocalizationService localizationService);
}