using Microsoft.AspNetCore.Mvc;

namespace MyBook.Controllers;

public class Sets : Controller
{
    public IActionResult Novelties()
    {
        return View();
    }
    
    public IActionResult BestBooks()
    {
        return View();
    }
    
    public IActionResult BestAudio()
    {
        return View();
    }
}