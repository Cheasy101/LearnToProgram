using Contracts.Requests.Home.GetIndex;
using MediatR;

namespace Application.Features.Queries.Home.FeedbackQuery;

public class InsertFeedBackQuery(FeedbackFeedDto feedbackDto) : IRequest<FeedbackFeedDto>
{
    public FeedbackFeedDto FeedbackDto { get; set; } = feedbackDto;
}