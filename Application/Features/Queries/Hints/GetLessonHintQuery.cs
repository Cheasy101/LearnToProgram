using Contracts.Requests.Hints;
using MediatR;

namespace Application.Features.Queries.Hints;

public record GetLessonHintQuery(Guid LessonId, Guid UserId) : IRequest<GetLessonHintDto>;
