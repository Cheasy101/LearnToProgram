namespace Application.Features.Commands.CrudLessons;

// Application/Features/Commands/Lessons/DeleteLessonCommandHandler.cs
using Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

public class DeleteLessonCommandHandler(IDbContext context) : IRequestHandler<DeleteLessonCommand>
{
    public async Task Handle(DeleteLessonCommand request, CancellationToken cancellationToken)
    {
        var lesson = await context.Lessons
            .FirstOrDefaultAsync(l => l.Id == request.LessonId, cancellationToken);

        if (lesson == null)
        {
            throw new Exception("Lesson not found");
        }

        context.Lessons.Remove(lesson);
        await context.SaveChangesAsync(cancellationToken);
    }
}