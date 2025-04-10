namespace Contracts.Requests.lesson;

public class SubmitLessonAsDoneDto
{
    public Guid LessonId { get; set; } 
    public Guid UserId { get; set; } 
}