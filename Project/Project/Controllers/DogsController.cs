using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class DogsController : Controller
    {
        public static List<Dog> dogs = new List<Dog>()
        {
            new Dog() { Id = Guid.NewGuid(), Name = "Rexi", Age = 2, Weight = 50, Breed = "Caucasian" },
            new Dog() { Id = Guid.NewGuid(), Name = "Nero", Age = 2, Weight = 40, Breed = "Chiuaua" },
        };

        // GET: Dogs
        public ActionResult Index()
        {
            return View(dogs);
        }

        // GET: Dogs/Details/5
        public ActionResult Details(Guid id)
        {
            Dog dog = dogs.FirstOrDefault(x => x.Id == id);

            return View(dog);
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
                Dog dog = new Dog();
                dog.Id = new Guid();

                dog.Name = collection.Get("Name");
                dog.Age = int.Parse(collection.Get("Age"));
                dog.Weight = int.Parse(collection.Get("Weight"));
                dog.Breed = collection.Get("Breed");

                dogs.Add(dog);

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
            Dog dog = dogs.FirstOrDefault(x => x.Id == id);

            return View(dog);
        }

        // POST: Dogs/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                Dog dog = dogs.FirstOrDefault(x => x.Id == id);

                dog.Name = collection.Get("Name");
                dog.Age = int.Parse(collection.Get("Age"));
                dog.Weight = int.Parse(collection.Get("Weight"));
                dog.Breed = collection.Get("Breed");

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
            Dog dog = dogs.FirstOrDefault(x => x.Id == id);

            return View(dog);
        }

        // POST: Dogs/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                Dog dog = dogs.FirstOrDefault(x => x.Id == id);

                dogs.Remove(dog);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
