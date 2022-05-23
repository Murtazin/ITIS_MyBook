using Microsoft.AspNetCore.Mvc;

namespace MyBook.Controllers;

public class Podcasters : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}