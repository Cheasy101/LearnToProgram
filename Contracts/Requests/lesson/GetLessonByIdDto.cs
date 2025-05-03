namespace Contracts.Requests.lesson;

public class GetLessonByIdDto
{
    public Guid Id { get; set; }

    /// <summary>
    /// Ссылка на фото урока
    /// </summary>
    public string? LessonPhotoUrl { get; set; }

    /// <summary>
    /// Полное описание урока
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Краткое описание урока
    /// </summary>
    public string? SmallDescription { get; set; }

    /// <summary>
    /// Ссылка на видео урока
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

    public DateTime CreatedAt { get; set; }
}