using Application.Interfaces;
using Contracts.Requests.Home.GetIndex;
using MediatR;

namespace Application.Features.Queries.TeacherAndAdmin;

public class GetFeedbackQueryHandler(IDbContext context) : IRequestHandler<GetFeedbackQuery, GetUserStatsResponse>
{
    public Task<GetUserStatsResponse> Handle(GetFeedbackQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}