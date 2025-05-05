using Application.Interfaces;
using Contracts.Requests.Hints;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Queries.Hints;

public class GetLessonHintQueryHandler(IDbContext context)
    : IRequestHandler<GetLessonHintQuery, GetLessonHintDto>
{
    public async Task<GetLessonHintDto> Handle(GetLessonHintQuery request, CancellationToken cancellationToken)
    {
        var hint = await context.UserLessonHint
            .Where(h => h.UserId == request.UserId && h.LessonId == request.LessonId)
            .FirstOrDefaultAsync(cancellationToken);

        return new GetLessonHintDto
        {
            HintText = hint?.HintText,
            AttemptsThreshold = hint?.AttemptsThreshold
        };
    }
}