using Application.Features.Queries.Home;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace learnToProgramm.Controllers;

public class HomeController(IMediator mediator) : Controller
{
    public async Task<IActionResult> Index(CancellationToken cancellationToken)
    {
        var query = new GetCoursesQuery();
        
        var response = await mediator.Send(query, cancellationToken);

        return View(response);
    }

}