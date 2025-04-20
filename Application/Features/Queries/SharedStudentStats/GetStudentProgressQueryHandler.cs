using Application.Interfaces;
using Contracts.Requests.SharedStudentStats;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Queries.SharedStudentStats;

public class GetStudentProgressQueryHandler(IDbContext context)
    : IRequestHandler<GetStudentProgressQuery, StudentProgressResponse>
{
    public async Task<StudentProgressResponse> Handle(GetStudentProgressQuery request, CancellationToken ct)
    {
        var allLessons = await context.Lessons
            .Select(x => new LessonDto
            {
                Id = x.Id,
                SmallDescription = x.SmallDescription,
                LessonPhotoUrl = x.LessonPhotoUrl
            })
            .ToListAsync(ct);

        var completedLessonIds = await context.UsersStats
            .Where(x => x.UserId == request.UserId)
            .Select(x => x.LessonId)
            .ToListAsync(ct);

        var response = new StudentProgressResponse
        {
            CompletedLessons = completedLessonIds.Count,
            TotalLessons = allLessons.Count,
            Completed = allLessons.Where(l => completedLessonIds.Contains(l.Id)).ToList(),
            Remaining = allLessons.Where(l => !completedLessonIds.Contains(l.Id)).ToList()
        };

        return response;
    }
}