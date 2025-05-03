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
    /// Ссылка на Видео
    /// </summary>
    public string? VideoLink { get; set; }

    /// <summary>
    /// Практическое задание для урока
    /// </summary>
    public string? PracticeTask { get; set; }

    /// <summary>
    /// Ожидаемый результат выполнения задания
    /// </summary>
    public string? ExpectedOutput { get; set; }

    /// <summary>
    /// Пример решения (необязательно)
    /// </summary>
    public string? SolutionCode { get; set; }

    /// <summary>
    /// Начальный код для редактора
    /// </summary>
    public string? InitialCode { get; set; }


    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}