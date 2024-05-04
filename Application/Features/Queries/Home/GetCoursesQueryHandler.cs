using System.Security.Claims;
using Application.Interfaces;
using Contracts.Requests.Home.GetIndex;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Queries.Home;

public class GetCoursesQueryHandler(IDbContext context, IHttpContextAccessor httpContextAccessor)
    : IRequestHandler<GetCoursesQuery, GetCoursesResponseDto>
{
    public async Task<GetCoursesResponseDto> Handle(GetCoursesQuery request, CancellationToken cancellationToken)
    {
        var userId = httpContextAccessor.HttpContext?.User.FindFirst(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

        var query = context.Lessons
            .Select(lesson => new
            {
                Lesson = lesson,
                IsDone = userId != null && context.UsersStats.Any(us => 
                    us.UserId.ToString() == userId && us.LessonId == lesson.Id && us.IsDone)
            });

        var courses = await query.Select(x => new GetCoursesResponseItemDto
        {
            Id = x.Lesson.Id,
            SmallDescription = x.Lesson.SmallDescription,
            LessonPhotoUrl = x.Lesson.LessonPhotoUrl,
            IsDone = x.IsDone
        }).ToListAsync(cancellationToken);

        return new GetCoursesResponseDto { Courses = courses };
    }
}