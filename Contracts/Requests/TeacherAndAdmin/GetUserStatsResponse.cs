namespace Contracts.Requests.TeacherAndAdmin;

public class GetUserStatsResponse
{
    public List<GetFeedbackResponseDto>? FeedbackResponse { get; set; } = [];
}

