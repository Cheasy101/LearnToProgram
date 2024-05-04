using Application.Interfaces;
using Contracts.Requests.Home.GetIndex;
using Contracts.Requests.TeacherAndAdmin;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Queries.TeacherAndAdmin;

public class GetFeedbackQueryHandler(IDbContext context) : IRequestHandler<GetFeedbackQuery, TeacherAndAdminResponse>
{
    public async Task<TeacherAndAdminResponse> Handle(GetFeedbackQuery request, CancellationToken cancellationToken)
    {

        var usersFeedback = await context.FeedbackFeeds.Select(x => new GetFeedbackResponseDto
        {
            FullName = x.FullName,
            EmailAddress = x.EmailAddress,
            UserMessage = x.UserMessage,
            Id = x.Id,
            CreatedAt = x.CreatedAt
        }).ToListAsync(cancellationToken: cancellationToken);
        
        
        return new TeacherAndAdminResponse{ FeedbackResponse = usersFeedback};
    }
}