using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExamPrep413.Models;

namespace ExamPrep413.Controllers;

public class HomeController : Controller
{
    

    public HomeController()
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }
}