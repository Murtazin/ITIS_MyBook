using Microsoft.AspNetCore.Mvc;

namespace MyBook.Controllers;

public class DashBoardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}