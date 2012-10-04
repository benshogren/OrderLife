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
    public class WeeklyDietController : Controller
    {
        private WeeklyDietDBContext db = new WeeklyDietDBContext();

        //
        // GET: /WeeklyDiet/

        public ViewResult Index()
        {
            return View(db.WeeklyDiet.ToList());
        }

        //
        // GET: /WeeklyDiet/Details/5

        public ViewResult Details(int id)
        {
            WeeklyDiet weeklydiet = db.WeeklyDiet.Find(id);
            return View(weeklydiet);
        }

        //
        // GET: /WeeklyDiet/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /WeeklyDiet/Create

        [HttpPost]
        public ActionResult Create(WeeklyDiet weeklydiet)
        {
            if (ModelState.IsValid)
            {
                db.WeeklyDiet.Add(weeklydiet);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(weeklydiet);
        }
        
        //
        // GET: /WeeklyDiet/Edit/5
 
        public ActionResult Edit(int id)
        {
            WeeklyDiet weeklydiet = db.WeeklyDiet.Find(id);
            return View(weeklydiet);
        }

        //
        // POST: /WeeklyDiet/Edit/5

        [HttpPost]
        public ActionResult Edit(WeeklyDiet weeklydiet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(weeklydiet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(weeklydiet);
        }

        //
        // GET: /WeeklyDiet/Delete/5
 
        public ActionResult Delete(int id)
        {
            WeeklyDiet weeklydiet = db.WeeklyDiet.Find(id);
            return View(weeklydiet);
        }

        //
        // POST: /WeeklyDiet/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            WeeklyDiet weeklydiet = db.WeeklyDiet.Find(id);
            db.WeeklyDiet.Remove(weeklydiet);
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