namespace Contracts.Requests.TeacherAndAdmin;

public class TeacherAndAdminResponse
{
    public List<GetFeedbackResponseDto>? FeedbackResponse { get; set; } = [];
    public List<GetUserStatsResponseDTO>? UserStatsResponse { get; set; } = [];

}

