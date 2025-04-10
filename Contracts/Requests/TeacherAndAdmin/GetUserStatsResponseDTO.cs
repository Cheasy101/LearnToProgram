namespace Contracts.Requests.TeacherAndAdmin;

public class GetUserStatsResponseDTO
{
    public bool IsDone { get; set; }
    public string? User { get; set; } = default!;
    public string? Lesson { get; set; } = default!;
}