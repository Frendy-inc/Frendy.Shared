using Frendy.Shared.Enums;
using Microsoft.AspNetCore.Identity;

namespace Frendy.Shared.Entities;

/// <summary>
/// Класс пользователя
/// </summary>
public class User : IdentityUser<Guid>
{
    /// <summary>
    /// Имя пользователя
    /// </summary>
    public string? FirstName { get; set; }
    /// <summary>
    /// Фамилия пользователя
    /// </summary>
    public string? LastName { get; set; }
    /// <summary>
    /// Имя и фамилия пользователя
    /// </summary>
    public string? FullName { get; set; }
    /// <summary>
    /// Ссылка на аватар пользователя
    /// </summary>
    public string? AvatarUrl { get; set; }
    /// <summary>
    /// Роль пользователя
    /// </summary>
    public UserRole Role { get; set; }
    /// <summary>
    /// Код подтверждения
    /// </summary>
    public string? ConfirmationCode { get; set; }
    /// <summary>
    /// Время жизни кода подтверждения
    /// </summary>
    /// <remarks>Устанавливается в тот момент, когда код подтверждения был отправлен</remarks>
    public DateTime? ConfirmationCodeExpires { get; set; }
    /// <summary>
    /// Дата регистрации пользователя
    /// </summary>
    public DateTime RegistrationDate { get; set; }
    /// <summary>
    /// Суммарное время активности пользователя
    /// </summary>
    public DateTime? ActivityTime { get; set; }
    /// <summary>
    /// Идентификатор пригласившего пользователя 
    /// </summary>
    public Guid? InviterId { get; set; }
    /// <summary>
    /// Приоритетный тип авторизации
    /// </summary>
    /// <remarks>При регистрации выставляется тот тип, по которому она производится</remarks>
    public AuthType AuthTypePriority { get; set; }
    /// <summary>
    /// Идентификатор пользователя в Google
    /// </summary>
    public string? GoogleId { get; set; } 
    /// <summary>
    /// Идентификатор пользователя в Yandex
    /// </summary>
    public string? YandexId { get; set; }
    /// <summary>
    /// Идентификатор пользователя в VK
    /// </summary>
    public string? VkId { get; set; }
    // /// <summary>
    // /// Сообщение подтверждения действия
    // /// </summary>
    // /// <remarks>
    // /// Это может быть подтверждение регистрации, сброса пароля и т.д. 
    // /// Устанавливается вместе с ConfirmType
    // /// </remarks>
    // public string? ConfirmMessage { get; set; }
    // /// <summary>
    // /// Тип действия подтверждения
    // /// </summary>
    // /// <remarks>
    // /// Устанавливается вместе с ConfirmMessage
    // /// </remarks>
    // public ConfirmType? ConfirmType { get; set; }
    /// <summary>
    /// Пол пользователя
    /// </summary>
    public Sex Sex { get; set; }
    /// <summary>
    /// Дата рождения
    /// </summary>
    public DateTime? Birthday { get; set; }
    /// <summary>
    /// Причина блокировки
    /// </summary>
    public string? LockoutReason { get; set; }
    /// <summary>
    /// Язык отображения
    /// </summary>
    public Language Language { get; set; }
    
    /// <summary>
    /// Устройства пользователя
    /// </summary>
    public List<Device> Devices { get; set; } = new();
    
    /// <summary>
    /// Список друзей пользователя
    /// </summary>
    public List<User> FriendsReceived { get; set; } = new();
    /// <summary>
    /// Список друзей, добавивших пользователя
    /// </summary>
    public List<User> FriendsSent { get; set; } = new();
    /// <summary>
    /// Список промежуточных объектов друзей пользователя
    /// </summary>
    public List<UserFriend> UserFriends { get; set; } = new();
    
    /// <summary>
    /// Список использованных сервисов
    /// </summary>
    public List<Service> Services { get; set; } = new();
    /// <summary>
    /// Список промежуточных объектов использованных сервисов
    /// </summary>
    public List<UserService> UserServices { get; set; } = new();
    
    /// <summary>
    /// Список список посещённых городов
    /// </summary>
    public List<UserCity> Cities { get; set; } = new();
    
    /// <summary>
    /// Список встреч
    /// </summary>
    public List<Meeting> Meetings { get; set; } = new();
    /// <summary>
    /// Список промежуточных объектов встреч
    /// </summary>
    public List<UserMeeting> UserMeetings { get; set; } = new();
    
    /// <summary>
    /// Список чатов пользователя
    /// </summary>
    public List<Chat> Chats { get; set; } = new();
    /// <summary>
    /// Список промежуточных объектов чатов пользователя
    /// </summary>
    public List<UserChat> UserChats { get; set; } = new();
    
    /// <summary>
    /// Прогресс пользователя в достижениях
    /// </summary>
    public List<Achievement> Achievements { get; set; } = new();
    /// <summary>
    /// Список промежуточных объектов прогрессов пользователя в достижениях
    /// </summary>
    public List<UserAchievement> UserAchievements { get; set; } = new();
    
    /// <summary>
    /// Прогресс пользователя в уровнях достижений
    /// </summary>
    public List<AchievementLevel> AchievementLevels { get; set; } = new();
    /// <summary>
    /// Список промежуточных объектов прогрессов пользователя в уровнях достижений
    /// </summary>
    public List<UserAchievementLevel> UserAchievementLevels { get; set; } = new();
    
    /// <summary>
    /// Список просмотренных сообщений
    /// </summary>
    public List<Message> ViewedMessages { get; set; } = new();
    /// <summary>
    /// Список промежуточных объектов просмотренных сообщений
    /// </summary>
    public List<UserMessage> UserMessages { get; set; } = new();

    /// <summary>
    /// Отправленные сообщения
    /// </summary>
    public List<Message> Messages { get; set; } = new();
    
    /// <summary>
    /// Список стикеров, доступных пользователю
    /// </summary>
    public List<Sticker> Stickers { get; set; } = new();

    /// <summary>
    /// Список уведомлений, отправленных пользователю
    /// </summary>
    public List<Notification> Notifications { get; set; } = new();
    /// <summary>
    /// Список промежуточных объектов стикеров, доступных пользователю
    /// </summary>
    public List<UserSticker> UserStickers { get; set; } = new();
    
    /// <summary>
    /// Список наборов стикеров, доступных пользователю
    /// </summary>
    public List<StickerSet> StickerSets { get; set; } = new();
    /// <summary>
    /// Список промежуточных объектов наборов стикеров, доступных пользователю
    /// </summary>
    public List<UserStickerSet> UserStickerSets { get; set; } = new();
}