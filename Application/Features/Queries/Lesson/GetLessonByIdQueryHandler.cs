using Application.Interfaces;
using Contracts.Requests.Home.GetIndex;
using Contracts.Requests.lesson;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Queries.Lesson;

public class GetLessonByIdQueryHandler(IDbContext context)
    : IRequestHandler<GetLessonByIdQuery, LessonPageResponseModel>
{

    public async Task<LessonPageResponseModel> Handle(GetLessonByIdQuery request, CancellationToken cancellationToken)
    {
        // Запрос данных урока из базы данных по ID
        var lessonEntity = await context.Lessons
            .Where(l => l.Id == request.Id)  // Убедитесь, что Id является свойством класса Lesson
            .Select(l => new GetLessonByIdDto
            {
                Id = l.Id,
                LessonPhotoUrl = l.LessonPhotoUrl,
                Description = l.Description,
                SmallDescription = l.SmallDescription,
                VideoLink = l.VideoLink,
                CreatedAt = l.CreatedAt
            })
            .FirstOrDefaultAsync(cancellationToken);


        // Проверка на наличие данных
        return lessonEntity == null ?
            new LessonPageResponseModel { LessonByIdDto = null } :
            new LessonPageResponseModel { LessonByIdDto = lessonEntity };
    }
}