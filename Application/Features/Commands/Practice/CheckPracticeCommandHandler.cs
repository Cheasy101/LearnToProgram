using Application.Interfaces;
using Contracts.Requests.Practice;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Commands.Practice;

public class CheckPracticeCommandHandler(IDbContext context)
    : IRequestHandler<CheckPracticeCommand, PracticeCheckResult>
{
    public async Task<PracticeCheckResult> Handle(
        CheckPracticeCommand request,
        CancellationToken cancellationToken)
    {
        // 1. Получаем данные урока
        var lesson = await context.Lessons
            .FirstOrDefaultAsync(l => l.Id == request.LessonId, cancellationToken);

        if (lesson == null) throw new Exception("Урок не найден");

        // 2. Работа со статистикой
        var userStats = await context.UsersStats
            .FirstOrDefaultAsync(s => s.UserId == request.UserId
                                      && s.LessonId == request.LessonId, cancellationToken);

        if (userStats == null)
        {
            userStats = new UserStats
            {
                Id = Guid.NewGuid(),
                UserId = request.UserId,
                LessonId = request.LessonId,
                Attempts = 0,
                IsDone = false
            };
            await context.UsersStats.AddAsync(userStats, cancellationToken);
        }

        // 3. Сравнение вывода
        bool isMatch = NormalizeOutput(request.UserOutput) ==
                       NormalizeOutput(lesson.ExpectedOutput);

        // 4. Обновление статистики
        userStats.Attempts++;
        userStats.IsDone = isMatch;
        await context.SaveChangesAsync(cancellationToken);

        return new PracticeCheckResult(
            IsSuccessful: isMatch,
            Attempts: userStats.Attempts,
            ExpectedOutput: isMatch ? null : lesson.ExpectedOutput);
    }

    private string NormalizeOutput(string output)
    {
        return output?
            .Trim()
            .Replace("\r", "")
            .Replace("\n", " ")
            .Replace("  ", " ")
            .ToLower();
    }
}