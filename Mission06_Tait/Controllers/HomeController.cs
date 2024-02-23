using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission06_Tait.Models;
using System;
using System.Diagnostics;

namespace Mission06_Tait.Controllers
{
    public class HomeController : Controller
    {
        private JoelHiltonMovieCollectionContext _context;

        //create the constructor
        public HomeController(JoelHiltonMovieCollectionContext movieInfo) 
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
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.Category)
                .ToList();

            return View("EnterMovies", new Movies());
        }

        [HttpPost]
        public IActionResult EnterMovies(Movies response)
        {
            if (!ModelState.IsValid) 
            {
                return View(response);
                //add records to the database and save changes
               
            }
            else
            {
                ViewBag.Categories = _context.Categories.ToList();

                _context.Movies.Add(response);

                _context.SaveChanges();

                return View("Confirmation", response);
            }
            
        }
        public IActionResult MovieList ()
        {
            //linq query where we pull data from our dataset
            var movieSet = _context.Movies.Include(x => x.Category)
                .OrderBy(x => x.MovieId).ToList();

            return View(movieSet);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.Category).ToList();

            return View("EnterMovies", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit (Movies updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete (Movies deleteInfo)
        {
            _context.Movies.Remove(deleteInfo);
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }

    }
}
