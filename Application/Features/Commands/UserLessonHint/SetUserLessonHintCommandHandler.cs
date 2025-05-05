using Application.Interfaces;
using Contracts.Requests.lesson;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Commands.UserLessonHint;

public class SetUserLessonHintCommandHandler(IDbContext context)
    : IRequestHandler<SetUserLessonHintCommand>
{
    public async Task Handle(SetUserLessonHintCommand request, CancellationToken cancellationToken)
    {
        var hint = await context.UserLessonHint
            .FirstOrDefaultAsync(h => h.UserId == request.UserId && h.LessonId == request.LessonId, cancellationToken);

        if (hint == null)
        {
            hint = new Domain.Entities.UserLessonHint
            {
                Id = Guid.NewGuid(),
                UserId = request.UserId,
                LessonId = request.LessonId,
                HintText = request.Hint,
                AttemptsThreshold = request.AttemptsThreshold
            };
            await context.UserLessonHint.AddAsync(hint, cancellationToken);
        }
        else
        {
            hint.HintText = request.Hint;
            hint.AttemptsThreshold = request.AttemptsThreshold;
        }

        await context.SaveChangesAsync(cancellationToken);
    }
}