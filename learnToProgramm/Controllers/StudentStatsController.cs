using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace learnToProgramm.Controllers;

[Authorize(Roles = "Teacher, Admin")] // Убедитесь, что только авторизованные пользователи с нужными ролями имеют доступ
public class StudentStatsController: Controller
{
        public IActionResult Index() => View();
}