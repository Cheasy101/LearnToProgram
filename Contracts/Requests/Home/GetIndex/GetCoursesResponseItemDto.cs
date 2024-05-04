namespace Contracts.Requests.Home.GetIndex;

public class GetCoursesResponseItemDto
{
    public Guid Id { get; set; }
    public string? LessonPhotoUrl { get; set; }
    public string? SmallDescription { get; set; }

    public bool IsDone { get; set; }
}