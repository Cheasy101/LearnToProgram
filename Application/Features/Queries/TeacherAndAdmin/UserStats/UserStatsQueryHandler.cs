using Application.Interfaces;
using Contracts.Requests.TeacherAndAdmin;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Queries.TeacherAndAdmin.UserStats;

public class UserStatsQueryHandler(IDbContext context) : IRequestHandler<UserStatsQuery, TeacherAndAdminResponse>
{
    public async Task<TeacherAndAdminResponse> Handle(UserStatsQuery request, CancellationToken cancellationToken)
    {
        var userStats = await context.UsersStats.Select(x => new GetUserStatsResponseDTO
        {
          IsDone = x.IsDone,
          User = x.User.UserName,
          Lesson = x.Lesson.SmallDescription
        }).ToListAsync(cancellationToken: cancellationToken);

        return new TeacherAndAdminResponse{UserStatsResponse = userStats};
    }
}