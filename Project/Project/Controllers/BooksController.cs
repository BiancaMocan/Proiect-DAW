using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class BooksController : Controller
    {
        public static List<Book> books = new List<Book>()
        {
            new Book() { Id = Guid.NewGuid(), Title = "Fluturi", Author = "Irina Binder", Genre = "Romantic", Year = 2016 },
            new Book() { Id = Guid.NewGuid(), Title = "Insomnii", Author = "Irina Binder", Genre = "Romantic", Year = 2018 },
        };

        // GET: Dogs
        public ActionResult Index()
        {
            return View(books);
        }

        // GET: Dogs/Details/5
        public ActionResult Details(Guid id)
        {
            Book book = books.FirstOrDefault(x => x.Id == id);

            return View(book);
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
                Book book = new Book();
                book.Id = new Guid();

                book.Title = collection.Get("Title");
                book.Author = collection.Get("Author");
                book.Genre = collection.Get("Genre");
                book.Year = int.Parse(collection.Get("Year"));

                books.Add(book);

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
            Book book = books.FirstOrDefault(x => x.Id == id);

            return View(book);
        }

        // POST: Dogs/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                Book book = books.FirstOrDefault(x => x.Id == id);

                book.Title = collection.Get("Title");
                book.Author = collection.Get("Author");
                book.Genre = collection.Get("Genre");
                book.Year = int.Parse(collection.Get("Year"));

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
            Book book = books.FirstOrDefault(x => x.Id == id);

            return View(book);
        }

        // POST: Dogs/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                Book book = books.FirstOrDefault(x => x.Id == id);

                books.Remove(book);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}