namespace Contracts.Requests.Manager.LessonsCrud;

// Contracts/Requests/lesson/Admin
public class AdminLessonListDto
{
    public Guid Id { get; set; }
    public string? SmallDescription { get; set; }
    public string? LessonPhotoUrl { get; set; }
    public string? VideoLink { get; set; }
}


