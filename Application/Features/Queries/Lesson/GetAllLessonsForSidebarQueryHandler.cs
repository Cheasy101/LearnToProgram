using Application.Interfaces;
using Contracts.Requests.lesson;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Queries.Lesson;

public class GetAllLessonsForSidebarQueryHandler(IDbContext context)
    : IRequestHandler<GetAllLessonsForSidebarQuery, LessonPageResponseModel>
{
    public async Task<LessonPageResponseModel> Handle(GetAllLessonsForSidebarQuery request, CancellationToken cancellationToken)
    {
        var lessons = await context.Lessons.Select(x => new LessonsForSidebarDto
        {
            Id = x.Id,
            Description = x.SmallDescription
        }).ToListAsync(cancellationToken);

        return new LessonPageResponseModel{AllLessonsForSidebarDto = lessons};
    }
}