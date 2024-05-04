using Application.Features.Queries.TeacherAndAdmin;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
}