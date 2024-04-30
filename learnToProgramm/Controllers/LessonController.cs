using Application.Features.Queries.Lesson;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace learnToProgramm.Controllers;

public class LessonController(IMediator mediator) : Controller
{
    // public IActionResult Index() => View();

    public async Task<IActionResult> Index(Guid id, CancellationToken cancellationToken)
    {
        var query = new GetLessonByIdQuery(id);
        var lesson = await mediator.Send(query, cancellationToken);

        return View(lesson); // Возвращает представление с моделью урока
    }
}