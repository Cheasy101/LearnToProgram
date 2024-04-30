using Application.Interfaces;
using Contracts.Requests.Home.GetIndex;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

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
            CreatedAt = DateTime.UtcNow, // assuming creation time is set at this point
            UpdatedAt = DateTime.UtcNow
        };

        context.FeedbackFeeds.Add(feedback);
        await context.SaveChangesAsync(cancellationToken);

        return request.FeedbackDto; // Return the DTO, maybe now with an updated ID if needed
    }

}