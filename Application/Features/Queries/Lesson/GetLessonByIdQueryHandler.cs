using Application.Interfaces;
using Contracts.Requests.lesson;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Queries.Lesson;

public class GetLessonByIdQueryHandler(IDbContext context)
    : IRequestHandler<GetLessonByIdQuery, LessonPageResponseModel>
{
    public async Task<LessonPageResponseModel> Handle(GetLessonByIdQuery request, CancellationToken cancellationToken)
    {
        var lessonEntity = await context.Lessons
            .Where(l => l.Id == request.Id)
            .Select(l => new GetLessonByIdDto
            {
                Id = l.Id,
                LessonPhotoUrl = l.LessonPhotoUrl,
                Description = l.Description,
                SmallDescription = l.SmallDescription,
                VideoLink = l.VideoLink,
                PracticeTask = l.PracticeTask,
                ExpectedOutput = l.ExpectedOutput,
                SolutionCode = l.SolutionCode,
                InitialCode = l.InitialCode,
                CreatedAt = l.CreatedAt
            })
            .FirstOrDefaultAsync(cancellationToken);

        if (lessonEntity == null)
        {
            throw new NullReferenceException($"Lesson with id {request.Id} not found");
        }

        var lessons = await context.Lessons
            .Where(x => x.Id != request.Id) // Исключаем текущий урок из списка связанных
            .Select(x => new LessonsForSidebarDto
            {
                Id = x.Id,
                Description = x.SmallDescription
            })
            .ToListAsync(cancellationToken);

        return new LessonPageResponseModel
        {
            AllLessonsForSidebarDto = lessons,
            LessonByIdDto = lessonEntity
        };
    }
}