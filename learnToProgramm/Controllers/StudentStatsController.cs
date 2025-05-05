using Application.Features.Commands.UserLessonHint;
using Application.Features.Queries.TeacherAndAdmin.UserStats;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace learnToProgramm.Controllers;

[Authorize(Roles = "Teacher, Admin")]
public class StudentStatsController(IMediator mediator) : Controller
{
    public async Task<IActionResult> Index(CancellationToken cancellationToken)
    {
        var query = new UserStatsQuery();
        var response = await mediator.Send(query, cancellationToken);

        return View(response);
    }

    [HttpPost("set-user-hint")]
    public async Task<IActionResult> SetUserHint([FromBody] SetUserLessonHintRequest request, CancellationToken ct)
    {
        var command =
            new SetUserLessonHintCommand(request.UserId, request.LessonId, request.Hint, request.AttemptsThreshold);
        await mediator.Send(command, ct);
        return Ok();
    }
}

public record SetUserLessonHintRequest(Guid UserId, Guid LessonId, string Hint, int AttemptsThreshold);