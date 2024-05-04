using Application.Interfaces;
using Contracts.Requests.lesson;
using Domain.Entities;
using MediatR;

namespace Application.Features.Queries.Lesson;

public class SubmitLessonByIdQueryHandler(IDbContext context)
    : IRequestHandler<SubmitLessonByIdQuery, SubmitLessonAsDoneDto>
{
    public async Task<SubmitLessonAsDoneDto> Handle(SubmitLessonByIdQuery request, CancellationToken cancellationToken)
    {
        var submitLesson = new UserStats
        {
            Id = Guid.NewGuid(),
            LessonId = request.SubmitLessonAsDone.LessonId,
            UserId = request.SubmitLessonAsDone.UserId,
            IsDone = true
        };

        context.UsersStats.Add(submitLesson);
        await context.SaveChangesAsync(cancellationToken);

        return request.SubmitLessonAsDone;
    }
}