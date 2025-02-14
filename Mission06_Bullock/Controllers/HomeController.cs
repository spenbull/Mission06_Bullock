using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Bullock.Models;

namespace Mission06_LastName.Controllers;

public class HomeController : Controller
{
    private AddMovieContext _context;

    public HomeController(AddMovieContext temp)
    {
        _context = temp;
    }

    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult FindOutAboutJoel()
    {
        return View("MeetJoel");
    }
    
    [HttpGet]
    public IActionResult AddMovie()
    {
        return View("AddMovie");
    }

    [HttpPost]
    public IActionResult AddMovie(Application response)
    {
        _context.Applications.Add(response);
        _context.SaveChanges();

        return View("Confirmation",response);
    }
    

}