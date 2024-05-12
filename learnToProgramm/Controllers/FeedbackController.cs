using Application.Features.Queries.Home.FeedbackQuery;
using Application.Features.Queries.TeacherAndAdmin;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace learnToProgramm.Controllers;

[Authorize(Roles = "Teacher, Admin")] // Убедитесь, что только авторизованные пользователи с нужными ролями имеют доступ
public class FeedbackController(IMediator mediator) : Controller
{
    public async Task<IActionResult> Index(CancellationToken cancellationToken)
    {
        var query = new GetFeedbackQuery();
        var response = await mediator.Send(query, cancellationToken);

        return View(response);
    }

    [HttpGet]
    public async Task<IActionResult> DeleteFeedbackById(Guid id,
        CancellationToken cancellationToken)
    {
        var query = new DeleteFeedbackByIdQuery(id);
        await mediator.Send(query, cancellationToken);

        return RedirectToAction("Index");
    }
}