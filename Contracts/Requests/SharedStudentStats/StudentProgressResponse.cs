namespace Contracts.Requests.SharedStudentStats;

public class StudentProgressResponse
{
    public int CompletedLessons { get; set; }
    public int TotalLessons { get; set; }
    public int RemainingLessons => TotalLessons - CompletedLessons;

    public List<LessonDto> Completed { get; set; } = new();
    public List<LessonDto> Remaining { get; set; } = new();
}

public class LessonDto
{
    public Guid Id { get; set; }
    public string? SmallDescription { get; set; } = "";
    public string? LessonPhotoUrl { get; set; }
}