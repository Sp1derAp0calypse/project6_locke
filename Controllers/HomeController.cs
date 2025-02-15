using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using project6.Models;

namespace project6.Controllers;

public class HomeController : Controller
{
    private MovieContext _context;

    public HomeController(MovieContext someName) //Constructor
    {
        _context = someName;
    }

    public IActionResult Index() //Main page
    {
        return View();
    }

    public IActionResult AboutJoel()
    {
        return View();
    }

    [HttpGet]
    public IActionResult AddMovie()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddMovie(Movie response)
    {
        _context.Movies.Add(response);
        _context.SaveChanges();

        return View("Confirmation", response);
    }
}
