using System.Security.Claims;
using Application.Features.Queries.Home;
using Application.Features.Queries.Home.FeedbackQuery;
using Contracts.Requests.Home.GetIndex;
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
    
    
    [HttpPost]
    public async Task<IActionResult> SubmitFeedback(FeedbackFeedDto feedbackDto, CancellationToken cancellationToken)
    {
        var command = new InsertFeedBackQuery(feedbackDto);
        await mediator.Send(command, cancellationToken);
    
        return RedirectToAction("Index"); 
    }
}