using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderLife.Models;
using OrderLife.Views.Health.ViewModels;
using OrderLife.Domain;
using System.Text;


namespace OrderLife.Controllers
{ 
    public class HealthController : Controller
    {
        private ExercisesDBContext db = new ExercisesDBContext();
        private WorkoutDescriptionDBContext wdb = new WorkoutDescriptionDBContext();


        public ActionResult HealthHub1()
        {
            return View();
        } 

        //
        // GET: /Health/

        public ViewResult Index() {
            var exercises = db.Exercises.ToList();
            var workouts = wdb.WorkoutDescription.ToList();
            var exviewmodels = new List<ExerciseViewModel>();
            var wviewmodels = new List <WorkoutViewModel>();
            var TableData = new ExerciseViewModel[7, 24];
            foreach (var exercise in exercises) {
                var a = new ExerciseViewModel();
                a.Day = exercise.Day;
                a.Time = exercise.Time;
                a.Exercise = exercise.Exercise;
                a.ID = exercise.ID;
                a.DayName = new DatePretty().Prettify(a.Day);
                exviewmodels.Add(a);
                TableData[a.Day - 1, a.Time] = a;
            }
            foreach (var workout in workouts) {
                var a = new WorkoutViewModel();
                a.Name = workout.Name;
                a.Description = workout.Description;
                wviewmodels.Add(a);
            }
            var VMIndex = new ExerciseViewModelIndex();
            VMIndex.exercises = exviewmodels;
            VMIndex.workouts = wviewmodels;
            VMIndex.TableData = TableData;
            return View(VMIndex);
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

        public ActionResult Create(int Day, int Time) {
            var Ex = new Exercises();
            Ex.Day = Day;
            Ex.Time = Time;
            Ex.DayName = new DatePretty().Prettify(Day);
            return View(Ex);
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



        public ViewResult DetailsWorkout(int id) {
            WorkoutDescription workouts = wdb.WorkoutDescription.Find(id);
            return View(workouts);
        }

        //
        // GET: /Health/Create

        public ActionResult CreateWorkout(string Name, string Description) {
            var wo = new WorkoutDescription();
            wo.Name = Name;
            wo.Description = Description;
            return View(wo);
        }

        //
        // POST: /Health/Create

        [HttpPost]
        public ActionResult CreateWorkout(WorkoutDescription workouts) {
            if (ModelState.IsValid) {
                wdb.WorkoutDescription.Add(workouts);
                wdb.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(workouts);
        }

        //
        // GET: /Health/Edit/5

        public ActionResult Edit(int id) {
            Exercises exercises = db.Exercises.Find(id);
            return View(exercises);
        }

        //
        // POST: /Health/Edit/5

        [HttpPost]
        public ActionResult Edit(Exercises exercises) {
            if (ModelState.IsValid) {
                db.Entry(exercises).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(exercises);
        }

        //
        // GET: /Health/Delete/5

        public ActionResult Delete(int id) {
            Exercises exercises = db.Exercises.Find(id);
            return View(exercises);
        }

        //
        // POST: /Health/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id) {
            Exercises exercises = db.Exercises.Find(id);
            db.Exercises.Remove(exercises);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}