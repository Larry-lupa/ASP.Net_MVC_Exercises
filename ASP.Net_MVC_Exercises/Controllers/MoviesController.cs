using System.Collections.Generic;
using System.Web.Mvc;
using ASP.Net_MVC_Exercises.Models;

namespace ASP.Net_MVC_Exercises.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie() { Id = 1, Name = "Shrek" },
                new Movie() { Id = 2, Name = "Wall-e"}
            };
        }
    }
}