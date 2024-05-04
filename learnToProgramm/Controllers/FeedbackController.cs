using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace learnToProgramm.Controllers;

[Authorize(Roles = "Teacher, Admin")] // Убедитесь, что только авторизованные пользователи с нужными ролями имеют доступ
public class FeedbackController : Controller
{
        public IActionResult Index() => View();
}