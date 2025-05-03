using Application.Interfaces;
using Contracts.Requests.TeacherAndAdmin;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Queries.TeacherAndAdmin.UserStats;

public class UserStatsQueryHandler(IDbContext context) : IRequestHandler<UserStatsQuery, TeacherAndAdminResponse>
{
    public async Task<TeacherAndAdminResponse> Handle(UserStatsQuery request, CancellationToken cancellationToken)
    {
        // 1️⃣ Загружаем все подсказки в память и организуем быстрый словарь для поиска
        var hintsDictionary = await context.UserLessonHint
            .AsNoTracking()
            .ToDictionaryAsync(
                key => new { key.UserId, key.LessonId },
                value => value,
                cancellationToken
            );

        // 2️⃣ Загружаем статистику пользователей и уроков
        var stats = await context.UsersStats
            .Include(x => x.User)
            .Include(x => x.Lesson)
            .ToListAsync(cancellationToken);

        // 3️⃣ Формируем итоговую модель для отображения в админке
        var userStats = stats.Select(x =>
        {
            // Пытаемся найти подсказку для этой пары User + Lesson
            hintsDictionary.TryGetValue(new { x.UserId, x.LessonId }, out var hint);

            return new GetUserStatsResponseDTO
            {
                IsDone = x.IsDone,
                User = x.User.UserName ?? x.User.Email ?? "Неизвестный пользователь",
                UserId = x.UserId,
                Lesson = x.Lesson.SmallDescription ?? "Неизвестный урок",
                LessonId = x.LessonId,
                Attempts = x.Attempts,
                Hint = hint?.HintText,
                HintAttemptsThreshold = hint?.AttemptsThreshold
            };
        }).ToList();

        // 4️⃣ Возвращаем DTO для страницы
        return new TeacherAndAdminResponse
        {
            UserStatsResponse = userStats
        };
    }
}