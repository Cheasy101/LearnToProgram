using System.Security.Claims;
using Application.Features.Queries.SharedStudentStats;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace learnToProgramm.Controllers;

[Authorize(Roles = "Student")]
[Route("student/progress")]
public class StudentProgressController(IMediator mediator) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index(CancellationToken ct)
    {
        var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty);
        var result = await mediator.Send(new GetStudentProgressQuery(userId), ct);
        return View($"~/Views/SharedStudentStats/index.cshtml", result);
    }
}