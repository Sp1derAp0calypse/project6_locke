using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        ViewBag.Categories = _context.Categories //categories bag
            .OrderBy(x => x.CategoryName)
            .ToList();

        return View(new Movie());
    }

    [HttpPost]
    public IActionResult AddMovie(Movie response)
    {
        _context.Movies.Add(response);
        _context.SaveChanges();

        return View("Confirmation", response);
    }

    public IActionResult ViewAll ()
    {
        var film = _context.Movies
            .Include(m => m.CategoryName) // Ensure CategoryName is loaded
            .OrderBy(x => x.Title)
            .ToList();

        return View(film);
    }
    [HttpGet]
    public IActionResult Edit (int Id)
    {
        var recordToEdit = _context.Movies
            .Single(x => x.MovieId == Id);

        ViewBag.Categories = _context.Categories //categories bag
        .OrderBy(x => x.CategoryName)
        .ToList();

        return View("AddMovie", recordToEdit);
    }

    [HttpPost]
    public IActionResult Edit(Movie updatedInfo)
    {
        _context.Update(updatedInfo);
        _context.SaveChanges();

        return RedirectToAction("ViewAll");
    }

    [HttpGet]
    public IActionResult Delete (int id)
    {
        var recordToDelete = _context.Movies
            .Single(x => x.MovieId == id);

        return View(recordToDelete);
    }

    [HttpPost]
    public IActionResult Delete (Movie movie)
    {
        _context.Movies.Remove(movie);
        _context.SaveChanges();

        return RedirectToAction("ViewAll");
    }
}
