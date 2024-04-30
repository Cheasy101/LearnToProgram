namespace Contracts.Requests.lesson;

public class GetLessonByIdDto
{
    public Guid Id { get; set; }

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

    public DateTime CreatedAt { get; set; }
}