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
    public class WeeklyDietEntryController : Controller
    {
        private AllDBContext db = new AllDBContext();

        //
        // GET: /WeeklyDietEntry/

        public ViewResult Index()
        {
            return View(db.WeeklyDietEntry.ToList());
        }

        //
        // GET: /WeeklyDietEntry/Details/5

        public ViewResult Details(int id)
        {
            WeeklyDietEntry weeklydietentry = db.WeeklyDietEntry.Find(id);
            return View(weeklydietentry);
        }

        //
        // GET: /WeeklyDietEntry/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /WeeklyDietEntry/Create

        [HttpPost]
        public ActionResult Create(WeeklyDietEntry weeklydietentry)
        {
            if (ModelState.IsValid)
            {
                db.WeeklyDietEntry.Add(weeklydietentry);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(weeklydietentry);
        }
        
        //
        // GET: /WeeklyDietEntry/Edit/5
 
        public ActionResult Edit(int id)
        {
            WeeklyDietEntry weeklydietentry = db.WeeklyDietEntry.Find(id);
            return View(weeklydietentry);
        }

        //
        // POST: /WeeklyDietEntry/Edit/5

        [HttpPost]
        public ActionResult Edit(WeeklyDietEntry weeklydietentry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(weeklydietentry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(weeklydietentry);
        }

        //
        // GET: /WeeklyDietEntry/Delete/5
 
        public ActionResult Delete(int id)
        {
            WeeklyDietEntry weeklydietentry = db.WeeklyDietEntry.Find(id);
            return View(weeklydietentry);
        }

        //
        // POST: /WeeklyDietEntry/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            WeeklyDietEntry weeklydietentry = db.WeeklyDietEntry.Find(id);
            db.WeeklyDietEntry.Remove(weeklydietentry);
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