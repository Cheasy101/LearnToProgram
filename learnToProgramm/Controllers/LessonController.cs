using Microsoft.AspNetCore.Mvc;

namespace learnToProgramm.Controllers;

public class LessonController : Controller
{
    public IActionResult Index() => View();

    // public async Task<IActionResult> Index([FromRoute] Guid lessonId)
    // {
    //     var query = new GetCourseById
    //     View();
    // }
}