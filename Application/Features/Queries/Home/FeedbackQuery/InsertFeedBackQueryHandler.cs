using Application.Interfaces;
using Contracts.Requests.Home.GetIndex;
using Domain.Entities;
using MediatR;

namespace Application.Features.Queries.Home.FeedbackQuery;

public class InsertFeedBackQueryHandler(IDbContext context) : IRequestHandler<InsertFeedBackQuery, FeedbackFeedDto>
{
    public async Task<FeedbackFeedDto> Handle(InsertFeedBackQuery request, CancellationToken cancellationToken)
    {
        var feedback = new FeedbackFeed
        {
            FullName = request.FeedbackDto.FullName,
            EmailAddress = request.FeedbackDto.EmailAddress,
            UserMessage = request.FeedbackDto.UserMessage,
            CreatedAt = DateTime.UtcNow, 
            UpdatedAt = DateTime.UtcNow
        };

        context.FeedbackFeeds.Add(feedback);
        await context.SaveChangesAsync(cancellationToken);

        return request.FeedbackDto;
    }

}