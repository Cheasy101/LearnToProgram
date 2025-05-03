using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class UserStats
{
    public Guid Id { get; set; }
    public Guid LessonId { get; set; }
    public Guid UserId { get; set; }
    public bool IsDone { get; set; }

    /// <summary>
    /// Код, который написал пользователь
    /// </summary>
    public string? UserCode { get; set; }

    /// <summary>
    /// Время выполнения задания (в секундах)
    /// </summary>
    public int? CompletionTime { get; set; }

    /// <summary>
    /// Количество попыток
    /// </summary>
    public int Attempts { get; set; }

    [ForeignKey(nameof(UserId))] 
    public User User { get; set; } = default!;

    [ForeignKey(nameof(LessonId))] 
    public Lesson Lesson { get; set; } = default!;
}