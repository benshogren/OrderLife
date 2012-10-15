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
    public class HobbiesController : Controller
    {
        private AllDBContext db = new AllDBContext();

        //
        // GET: /Hobbies/

        public ViewResult Index()
        {
            return View(db.Hobbies.ToList());
        }

        //
        // GET: /Hobbies/Details/5

        public ViewResult Details(int id)
        {
            Hobbies hobbies = db.Hobbies.Find(id);
            return View(hobbies);
        }

        //
        // GET: /Hobbies/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Hobbies/Create

        [HttpPost]
        public ActionResult Create(Hobbies hobbies)
        {
            if (ModelState.IsValid)
            {
                db.Hobbies.Add(hobbies);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(hobbies);
        }
        
        //
        // GET: /Hobbies/Edit/5
 
        public ActionResult Edit(int id)
        {
            Hobbies hobbies = db.Hobbies.Find(id);
            return View(hobbies);
        }

        //
        // POST: /Hobbies/Edit/5

        [HttpPost]
        public ActionResult Edit(Hobbies hobbies)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hobbies).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hobbies);
        }

        //
        // GET: /Hobbies/Delete/5
 
        public ActionResult Delete(int id)
        {
            Hobbies hobbies = db.Hobbies.Find(id);
            return View(hobbies);
        }

        //
        // POST: /Hobbies/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Hobbies hobbies = db.Hobbies.Find(id);
            db.Hobbies.Remove(hobbies);
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