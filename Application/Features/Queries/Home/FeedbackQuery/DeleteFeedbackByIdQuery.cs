using Contracts.Requests.Home.GetIndex;
using MediatR;

namespace Application.Features.Queries.Home.FeedbackQuery;

public class DeleteFeedbackByIdQuery(Guid id) : IRequest
{
    public Guid Id { get; } = id;
}