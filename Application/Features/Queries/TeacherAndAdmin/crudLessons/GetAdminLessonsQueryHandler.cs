using Application.Interfaces;
using Contracts.Requests.Manager.LessonsCrud;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Queries.TeacherAndAdmin.crudLessons;


public class GetAdminLessonsQueryHandler(IDbContext context)
    : IRequestHandler<GetAdminLessonsQuery, AdminLessonResponseModel>
{
    public async Task<AdminLessonResponseModel> Handle(GetAdminLessonsQuery request, CancellationToken ct)
    {
        var lessons = await context.Lessons
            .Select(x => new AdminLessonListDto
            {
                Id = x.Id,
                SmallDescription = x.SmallDescription,
                LessonPhotoUrl = x.LessonPhotoUrl,
                VideoLink = x.VideoLink
            })
            .ToListAsync(ct);

        return new AdminLessonResponseModel { Lessons = lessons };
    }
}
