using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult List()
        {
            List<Movie> movies = new List<Movie>();

            Movie movie = new Movie
            {
                Title = "The Shawshank Redemption",
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                Director = "Frank Darabont",
                Actors = new List<string> { "Tim Robbins", "Morgan Freeman", "Bob Gunton" }
            };

            movies.Add(movie);

            movie = new Movie
            {
                Title = "The Godfather",
                Description = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                Director = "Francis Ford Coppola",
                Actors = new List<string> { "Marlon Brando", "Al Pacino", "James Caan" }
            };

            movies.Add(movie);

            return View(movies);
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
