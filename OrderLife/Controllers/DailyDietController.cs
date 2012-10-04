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
    public class DailyDietController : Controller
    {
        private DailyDietDBContext db = new DailyDietDBContext();

        //
        // GET: /DailyDiet/

        public ViewResult Index()
        {
            return View(db.DailyDiet.ToList());
        }

        //
        // GET: /DailyDiet/Details/5

        public ViewResult Details(int id)
        {
            DailyDiet dailydiet = db.DailyDiet.Find(id);
            return View(dailydiet);
        }

        //
        // GET: /DailyDiet/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /DailyDiet/Create

        [HttpPost]
        public ActionResult Create(DailyDiet dailydiet)
        {
            if (ModelState.IsValid)
            {
                db.DailyDiet.Add(dailydiet);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(dailydiet);
        }
        
        //
        // GET: /DailyDiet/Edit/5
 
        public ActionResult Edit(int id)
        {
            DailyDiet dailydiet = db.DailyDiet.Find(id);
            return View(dailydiet);
        }

        //
        // POST: /DailyDiet/Edit/5

        [HttpPost]
        public ActionResult Edit(DailyDiet dailydiet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dailydiet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dailydiet);
        }

        //
        // GET: /DailyDiet/Delete/5
 
        public ActionResult Delete(int id)
        {
            DailyDiet dailydiet = db.DailyDiet.Find(id);
            return View(dailydiet);
        }

        //
        // POST: /DailyDiet/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            DailyDiet dailydiet = db.DailyDiet.Find(id);
            db.DailyDiet.Remove(dailydiet);
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