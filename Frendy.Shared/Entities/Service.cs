namespace Frendy.Shared.Entities;

/// <summary>
/// Класс сервиса
/// </summary>
public class Service
{
    /// <summary>
    /// Идентификатор сервиса
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Название сервиса
    /// </summary>
    public string Name { get; set; } = null!;
    /// <summary>
    /// Иконка сервиса
    /// </summary>
    public string IconUrl { get; set; } = null!;

    /// <summary>
    /// Список пользователей сервиса
    /// </summary>
    public List<User> Users { get; set; } = new();
    /// <summary>
    /// Список промежуточных объектов пользователей сервиса
    /// </summary>
    public List<UserService> UserServices { get; set; } = new();
}