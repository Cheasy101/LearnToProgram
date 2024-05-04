using Application.Features.Queries.Lesson;
using Contracts.Requests.lesson;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace learnToProgramm.Controllers;

public class LessonController(IMediator mediator) : Controller
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
}