using Application.Interfaces;
using Contracts.Requests.Home.GetIndex;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Queries.Home.FeedbackQuery;

public class DeleteFeedBackByIdQueryHandler(IDbContext context) : IRequestHandler<DeleteFeedbackByIdQuery>
{
    public async Task Handle(DeleteFeedbackByIdQuery request, CancellationToken cancellationToken)
    {
        var feedBack = await context.FeedbackFeeds.
            FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken: cancellationToken);

        if (feedBack != null) 
            context.FeedbackFeeds.Remove(feedBack);
        
        await context.SaveChangesAsync(cancellationToken);
    }
}