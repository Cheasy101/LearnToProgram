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
}