namespace Contracts.Requests.TeacherAndAdmin;

/// <summary>
/// DTO для статистики пользователя по конкретному уроку.
/// </summary>
public class GetUserStatsResponseDTO
{
    /// <summary>
    /// Пройден ли урок.
    /// </summary>
    public bool IsDone { get; set; }

    /// <summary>
    /// Имя пользователя или email.
    /// </summary>
    public string User { get; set; } = default!;

    /// <summary>
    /// Идентификатор пользователя.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Название урока.
    /// </summary>
    public string Lesson { get; set; } = default!;

    /// <summary>
    /// Идентификатор урока.
    /// </summary>
    public Guid LessonId { get; set; }

    /// <summary>
    /// Количество попыток решения задания.
    /// </summary>
    public int Attempts { get; set; }

    /// <summary>
    /// Есть ли подсказка.
    /// </summary>
    public bool HasHint => !string.IsNullOrEmpty(Hint);

    /// <summary>
    /// Текст подсказки (если есть).
    /// </summary>
    public string? Hint { get; set; }

    /// <summary>
    /// Порог показа подсказки.
    /// </summary>
    public int? HintAttemptsThreshold { get; set; }
}