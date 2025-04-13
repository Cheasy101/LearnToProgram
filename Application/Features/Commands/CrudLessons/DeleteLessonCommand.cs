namespace Application.Features.Commands.CrudLessons;

// Application/Features/Commands/Lessons/DeleteLessonCommand.cs
using MediatR;

public record DeleteLessonCommand(Guid LessonId) : IRequest;