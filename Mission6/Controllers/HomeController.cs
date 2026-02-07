using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
// using Mission6.Models;

namespace Mission6.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult GetToKnow()
    {
        return View();
    }

    public IActionResult NewMovie()
    {
        return View();
    }
    
}