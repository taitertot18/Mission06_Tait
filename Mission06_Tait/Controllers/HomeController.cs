using Microsoft.AspNetCore.Mvc;
using Mission06_Tait.Models;
using System.Diagnostics;

namespace Mission06_Tait.Controllers
{
    public class HomeController : Controller
    {
        private EnterMoviesContext _context;

        //create the constructor
        public HomeController(EnterMoviesContext movieInfo) 
        {
            _context = movieInfo;
        }

        // create actions for the views
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnow()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EnterMovies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnterMovies(Movie response)
        {
            //add records to the database and save changes
            _context.Movies.Add(response); 

            _context.SaveChanges();

            return View("Confirmation", response);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
