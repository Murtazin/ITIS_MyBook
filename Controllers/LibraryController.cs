using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MyBook.Controllers;

public class LibraryController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}