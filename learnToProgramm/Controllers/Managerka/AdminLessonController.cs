using System.Security.Claims;
using Application.Features.Commands.CrudLessons;
using Application.Features.Queries.Lesson;
using Application.Features.Queries.TeacherAndAdmin.crudLessons;
using Contracts.Requests.Manager.LessonsCrud;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace learnToProgramm.Controllers.Managerka;

[Authorize(Roles = "Admin,Teacher")]
[Route("admin/lessons")]
public class AdminLessonController(IMediator mediator) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index(CancellationToken ct)
    {
        var response = await mediator.Send(new GetAdminLessonsQuery(), ct);
        return View("~/Views/Managerka/LessonsCrud/AdminLesson.cshtml", response);
    }
    [HttpGet("edit/{id?}")]
    public async Task<IActionResult> Edit(Guid? id, CancellationToken ct)
    {
        var response = new AdminLessonResponseModel();

        if (id.HasValue)
        {
            var lesson = await mediator.Send(new GetLessonByIdQuery(id.Value), ct);
            response.EditLesson = new AdminLessonEditDto
            {
                Id = lesson.LessonByIdDto.Id,
                SmallDescription = lesson.LessonByIdDto.SmallDescription,
                Description = lesson.LessonByIdDto.Description,
                VideoLink = lesson.LessonByIdDto.VideoLink
            };
        }
        else
        {
            response.EditLesson = new AdminLessonEditDto();
        }

        return View(response);
    }

    [HttpPost("save")]
    public async Task<IActionResult> Save(AdminLessonEditDto dto, CancellationToken ct)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        await mediator.Send(new SaveLessonCommand(dto, Guid.Parse(userId)), ct);
        return RedirectToAction("Index");
    }

    [HttpPost("delete")]
    public async Task<IActionResult> Delete(Guid id, CancellationToken ct)
    {
        await mediator.Send(new DeleteLessonCommand(id), ct);
        return RedirectToAction("Index");
    }
    
    [HttpGet("create")]
    public IActionResult Create()
    {
        var dto = new AdminLessonEditDto(); // Пустая модель для формы создания
        return PartialView("~/Views/Managerka/LessonsCrud/_EditLessonPartial.cshtml", dto);
    }
}