using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            String title = "Film Adi";
            String description = "Film aciklamasi";
            String director = "Film yonetmeni";
            String[] actors = { "Oyuncu 1", "Oyuncu 2" };

            ViewBag.Title = title;
            ViewBag.Description = description;
            ViewBag.Director = director;
            ViewBag.Actors = actors;


            Movie movie = new Movie
            {
                Title = title,
                Description = description,
                Director = director,
                Actors = actors.ToList()
            };
            
            return View(movie);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
