using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class UserStats
{
    public Guid Id { get; set; }

    public Guid LessonId { get; set; }
    public Guid UserId { get; set; }
    public bool IsDone { get; set; }

    [ForeignKey(nameof(UserId))] 
    public User User { get; set; } = default!;

    [ForeignKey(nameof(LessonId))] 
    public Lesson Lesson { get; set; } = default!;
}