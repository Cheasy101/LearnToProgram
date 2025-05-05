using MediatR;

namespace Application.Features.Commands.UserLessonHint;

public record SetUserLessonHintCommand(Guid UserId, Guid LessonId, string Hint, int AttemptsThreshold) : IRequest;
