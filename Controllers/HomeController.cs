using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PeliculaLanding.Models;

namespace PeliculaLanding.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var pelicula = new MovieViewModel();
        return View(pelicula);
    }
   
}
