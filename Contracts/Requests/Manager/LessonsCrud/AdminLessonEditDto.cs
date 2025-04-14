using Microsoft.AspNetCore.Http;

namespace Contracts.Requests.Manager.LessonsCrud;

public class AdminLessonEditDto
{
    public Guid Id { get; set; }
    public string? SmallDescription { get; set; }
    public string? Description { get; set; }
    public string? VideoLink { get; set; }
    public string? PhotoLink { get; set; } // Сюда мы сохраним ссылку на файл
    public IFormFile? PhotoFile { get; set; } // Вью передаёт сюда файл
}