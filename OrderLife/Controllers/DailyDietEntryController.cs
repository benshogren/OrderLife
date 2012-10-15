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
    public class DailyDietEntryController : Controller
    {
        private AllDBContext db = new AllDBContext();

        //
        // GET: /DailyDietEntry/

        public ViewResult Index()
        {
            return View(db.DailyDietEntry.ToList());
        }

        //
        // GET: /DailyDietEntry/Details/5

        public ViewResult Details(int id)
        {
            DailyDietEntry dailydietentry = db.DailyDietEntry.Find(id);
            return View(dailydietentry);
        }

        //
        // GET: /DailyDietEntry/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /DailyDietEntry/Create

        [HttpPost]
        public ActionResult Create(DailyDietEntry dailydietentry)
        {
            if (ModelState.IsValid)
            {
                db.DailyDietEntry.Add(dailydietentry);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(dailydietentry);
        }
        
        //
        // GET: /DailyDietEntry/Edit/5
 
        public ActionResult Edit(int id)
        {
            DailyDietEntry dailydietentry = db.DailyDietEntry.Find(id);
            return View(dailydietentry);
        }

        //
        // POST: /DailyDietEntry/Edit/5

        [HttpPost]
        public ActionResult Edit(DailyDietEntry dailydietentry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dailydietentry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dailydietentry);
        }

        //
        // GET: /DailyDietEntry/Delete/5
 
        public ActionResult Delete(int id)
        {
            DailyDietEntry dailydietentry = db.DailyDietEntry.Find(id);
            return View(dailydietentry);
        }

        //
        // POST: /DailyDietEntry/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            DailyDietEntry dailydietentry = db.DailyDietEntry.Find(id);
            db.DailyDietEntry.Remove(dailydietentry);
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