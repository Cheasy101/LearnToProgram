using Domain.Abstractions;

namespace Domain.Entities;

public class Lesson : IAuditableEntity
{
    /// <summary>
    /// Ссылка на фото
    /// </summary>
    public string? LessonPhotoUrl { get; set; }

    /// <summary>
    /// Ссылка на фото
    /// </summary>
    public string? Description { get; set; }
    
    /// <summary>
    /// небольшое интро для понимание по уроку
    /// </summary>
    public string? SmallDescription { get; set; }

    /// <summary>
    /// Ссылка на фото
    /// </summary>
    public string? VideoLink { get; set; }

    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}