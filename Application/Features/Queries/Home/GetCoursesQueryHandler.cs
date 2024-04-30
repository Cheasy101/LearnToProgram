using Application.Interfaces;
using Contracts.Requests.Home.GetIndex;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Queries.Home;

public class GetCoursesQueryHandler(IDbContext context) : IRequestHandler<GetCoursesQuery, GetCoursesResponseDto>
{
    public async Task<GetCoursesResponseDto> Handle(GetCoursesQuery request, CancellationToken cancellationToken)
    {
        var courses = await context.Lessons.Select(x => new GetCoursesResponseItemDto
        {
            Id = x.Id,
            SmallDescription = x.SmallDescription,
            LessonPhotoUrl = x.LessonPhotoUrl
        }).ToListAsync(cancellationToken: cancellationToken);

        return new GetCoursesResponseDto{Courses = courses};
    }
}