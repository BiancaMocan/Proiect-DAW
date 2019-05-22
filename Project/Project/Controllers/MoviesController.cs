using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class MoviesController : Controller
    {
        public static List<Movie> movies = new List<Movie>()
        {
            new Movie() { Id = Guid.NewGuid(), Title = "Miss Bala", Duration = 120, Genre = "Action", Year = 2019 },
            new Movie() { Id = Guid.NewGuid(), Title = "Fast and Furios 5", Duration = 120, Genre = "Action", Year = 2016 },
        };

        // GET: Dogs
        public ActionResult Index()
        {
            return View(movies);
        }

        // GET: Dogs/Details/5
        public ActionResult Details(Guid id)
        {
            Movie movie = movies.FirstOrDefault(x => x.Id == id);

            return View(movie);
        }

        // GET: Dogs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dogs/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Movie movie = new Movie();
                movie.Id = new Guid();

                movie.Title = collection.Get("Title");
                movie.Duration = int.Parse(collection.Get("Duration"));
                movie.Genre = collection.Get("Genre");
                movie.Year = int.Parse(collection.Get("Year"));

                movies.Add(movie);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dogs/Edit/5
        public ActionResult Edit(Guid id)
        {
            Movie movie = movies.FirstOrDefault(x => x.Id == id);

            return View(movie);
        }

        // POST: Dogs/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                Movie movie = movies.FirstOrDefault(x => x.Id == id);

                movie.Title = collection.Get("Title");
                movie.Duration = int.Parse(collection.Get("Duration"));
                movie.Genre = collection.Get("Genre");
                movie.Year = int.Parse(collection.Get("Year"));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dogs/Delete/5
        public ActionResult Delete(Guid id)
        {
            Movie movie = movies.FirstOrDefault(x => x.Id == id);

            return View(movie);
        }

        // POST: Dogs/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                Movie movie = movies.FirstOrDefault(x => x.Id == id);

                movies.Remove(movie);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
