using System.Security.Claims;
using Application.Features.Commands.Practice;
using Application.Features.Queries.Lesson;
using Contracts.Requests.lesson;
using Contracts.Requests.Practice;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace learnToProgramm.Controllers;

public class LessonController(IMediator mediator, ILogger<LessonController> logger) : Controller
{
    public async Task<IActionResult> Index(Guid id, CancellationToken cancellationToken)
    {
        var lessonQuery = new GetLessonByIdQuery(id);
        var response = await mediator.Send(lessonQuery, cancellationToken);
        return View(response);
    }

    [HttpPost]
    public async Task<IActionResult> SubmitFeedback(SubmitLessonAsDoneDto submitLesson,
        CancellationToken cancellationToken)
    {
        var query = new SubmitLessonByIdQuery(submitLesson);
        await mediator.Send(query, cancellationToken);
        return RedirectToAction("Index", new { id = submitLesson.LessonId });
    }

    [HttpPost("/lesson/check-practice")] // <-- обратите внимание на полный абсолютный путь
    [Authorize]
    public async Task<IActionResult> CheckPractice(
        [FromBody] CheckPracticeRequest request,
        [FromServices] IMediator mediator)
    {
        
        logger.LogInformation("User claims:");
        foreach (var claim in User.Claims)
        {
            logger.LogInformation($"Type: {claim.Type}, Value: {claim.Value}");
        }
        
        var userId = Guid.Parse(
            User.FindFirstValue(ClaimTypes.NameIdentifier) 
            ?? throw new Exception("Не найден клейм NameIdentifier")
        );
        var command = new CheckPracticeCommand(
            request.LessonId,
            userId,
            request.UserOutput);

        var result = await mediator.Send(command);
        return Ok(result);
    }
}

// CheckPracticeRequest.cs (DTO для HTTP запроса)
public record CheckPracticeRequest(
    Guid LessonId,
    string UserOutput); // Только вывод от Piston