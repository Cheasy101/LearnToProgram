namespace Domain.Entities;

/// <summary>
/// Подсказка для конкретного пользователя и урока,
/// показываемая после определённого количества неудачных попыток.
/// </summary>
public class UserLessonHint
{
    /// <summary>
    /// Уникальный идентификатор подсказки.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Идентификатор пользователя, для которого создана подсказка.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Пользователь, связанный с подсказкой.
    /// </summary>
    public User User { get; set; } = null!;

    /// <summary>
    /// Идентификатор урока, к которому относится подсказка.
    /// </summary>
    public Guid LessonId { get; set; }

    /// <summary>
    /// Урок, связанный с подсказкой.
    /// </summary>
    public Lesson Lesson { get; set; } = null!;

    /// <summary>
    /// Текст подсказки, который будет показываться пользователю.
    /// </summary>
    public string HintText { get; set; } = string.Empty;

    /// <summary>
    /// Количество попыток, после которого подсказка будет отображаться.
    /// По умолчанию — 3.
    /// </summary>
    public int AttemptsThreshold { get; set; } = 10;
}