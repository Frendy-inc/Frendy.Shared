using System.ComponentModel.DataAnnotations;

namespace Frendy.Shared.Enums;

/// <summary>
/// Перечисление действий
/// </summary>
/// <remarks>При текущей реализации данные отсюда загружаются в БД при запуске приложения</remarks>
public enum Action
{
    [Display(Name = "Регистрация")]
    Registration = 1,

    [Display(Name = "Авторизация")]
    Authorization = 2,

    [Display(Name = "Блокировка пользователя")]
    BlockingTheUser = 3,

    [Display(Name = "Разблокировка пользователя")]
    UnblockingTheUser = 4,

    [Display(Name = "Смена пароля")]
    PasswordChange = 5,

    [Display(Name = "Обновление профиля")]
    ProfileUpdate = 6,

    [Display(Name = "Получение списка пользователей")]
    GettingUserList = 7,

    [Display(Name = "Смена роли пользователя")]
    ChangingTheUsersRole = 8,
    
    [Display(Name = "Добавление нового действия")]
    AddingNewAction = 9,
    
    [Display(Name = "Обновление действия")]
    ActionUpdate = 10,
}