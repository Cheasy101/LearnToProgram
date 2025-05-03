using Contracts.Requests.Practice;
using MediatR;

namespace Application.Features.Commands.Practice;

// CheckPracticeCommand.cs
public record CheckPracticeCommand(
    Guid LessonId,
    Guid UserId,
    string UserOutput) : IRequest<PracticeCheckResult>;
