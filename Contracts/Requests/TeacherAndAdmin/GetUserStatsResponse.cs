using Contracts.Requests.TeacherAndAdmin;

namespace Contracts.Requests.Home.GetIndex;

public class GetUserStatsResponse
{
    public List<GetFeedbackResponseDto>? FeedbackResponse { get; set; } = [];
}

