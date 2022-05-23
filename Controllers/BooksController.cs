using Microsoft.AspNetCore.Mvc;

namespace MyBook.Controllers;

public class BooksController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Audio()
    {
        return View();
    }

    public IActionResult Free()
    {
        return View();
    }
}