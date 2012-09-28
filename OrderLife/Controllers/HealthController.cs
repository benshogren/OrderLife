using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderLife.Models;

namespace OrderLife.Controllers
{ 
    public class HealthController : Controller
    {
        private ExercisesDBContext db = new ExercisesDBContext();

        //
        // GET: /Health/

        public ViewResult Index()
        {
            return View(db.Exercises.ToList());
        }

        //
        // GET: /Health/Details/5

        public ViewResult Details(int id)
        {
            Exercises exercises = db.Exercises.Find(id);
            return View(exercises);
        }

        //
        // GET: /Health/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Health/Create

        [HttpPost]
        public ActionResult Create(Exercises exercises)
        {
            if (ModelState.IsValid)
            {
                db.Exercises.Add(exercises);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(exercises);
        }
        
        //
        // GET: /Health/Edit/5
 
        public ActionResult Edit(int id)
        {
            Exercises exercises = db.Exercises.Find(id);
            return View(exercises);
        }

        //
        // POST: /Health/Edit/5

        [HttpPost]
        public ActionResult Edit(Exercises exercises)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exercises).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(exercises);
        }

        //
        // GET: /Health/Delete/5
 
        public ActionResult Delete(int id)
        {
            Exercises exercises = db.Exercises.Find(id);
            return View(exercises);
        }

        //
        // POST: /Health/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Exercises exercises = db.Exercises.Find(id);
            db.Exercises.Remove(exercises);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}