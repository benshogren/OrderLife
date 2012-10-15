using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderLife.Models;
using OrderLife.Domain;

namespace OrderLife.Controllers
{ 
    public class WorkoutController : Controller
    {
        private AllDBContext db = new AllDBContext();

        //
        // GET: /Workout/

        public ViewResult Index()
        {
            return View(db.WorkoutDescription.ToList());
        }

        //
        // GET: /Workout/Details/5

        public ViewResult Details(int id)
        {
            WorkoutDescription workoutdescription = db.WorkoutDescription.Find(id);
            return View(workoutdescription);
        }

        //
        // GET: /Workout/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Workout/Create

        [HttpPost]
        public ActionResult Create(WorkoutDescription workoutdescription)
        {
            if (ModelState.IsValid)
            {
                db.WorkoutDescription.Add(workoutdescription);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(workoutdescription);
        }
        
        //
        // GET: /Workout/Edit/5
 
        public ActionResult Edit(int id)
        {
            WorkoutDescription workoutdescription = db.WorkoutDescription.Find(id);
            return View(workoutdescription);
        }

        //
        // POST: /Workout/Edit/5

        [HttpPost]
        public ActionResult Edit(WorkoutDescription workoutdescription)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workoutdescription).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(workoutdescription);
        }

        //
        // GET: /Workout/Delete/5
 
        public ActionResult Delete(int id)
        {
            WorkoutDescription workoutdescription = db.WorkoutDescription.Find(id);
            return View(workoutdescription);
        }

        //
        // POST: /Workout/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            WorkoutDescription workoutdescription = db.WorkoutDescription.Find(id);
            db.WorkoutDescription.Remove(workoutdescription);
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