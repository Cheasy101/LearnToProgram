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
        // var getLessonsSidebar = new GetAllLessonsForSidebarQuery();

        var response = await mediator.Send(lessonQuery, cancellationToken);
        // var getLessonsSidebarTask = await mediator.Send(getLessonsSidebar, cancellationToken);

        // Подготовка модели для представления, которая включает данные урока и связанных уроков
        // var viewModel = new LessonPageResponseModel
        // {
        //     LessonByIdDto = lessonTask.LessonByIdDto,
        //     // AllLessonsForSidebarDto = getLessonsSidebarTask.AllLessonsForSidebarDto
        // };
        return View(response);
    }
}