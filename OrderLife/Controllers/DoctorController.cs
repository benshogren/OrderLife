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
    public class DoctorController : Controller
    {
        private AllDBContext db = new AllDBContext();

        //
        // GET: /Doctor/

        public ViewResult Index()
        {
            return View(db.Doctor.ToList());
        }

        //
        // GET: /Doctor/Details/5

        public ViewResult Details(int id)
        {
            Doctor doctor = db.Doctor.Find(id);
            return View(doctor);
        }

        //
        // GET: /Doctor/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Doctor/Create

        [HttpPost]
        public ActionResult Create(Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                db.Doctor.Add(doctor);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(doctor);
        }
        
        //
        // GET: /Doctor/Edit/5
 
        public ActionResult Edit(int id)
        {
            Doctor doctor = db.Doctor.Find(id);
            return View(doctor);
        }

        //
        // POST: /Doctor/Edit/5

        [HttpPost]
        public ActionResult Edit(Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(doctor);
        }

        //
        // GET: /Doctor/Delete/5
 
        public ActionResult Delete(int id)
        {
            Doctor doctor = db.Doctor.Find(id);
            return View(doctor);
        }

        //
        // POST: /Doctor/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Doctor doctor = db.Doctor.Find(id);
            db.Doctor.Remove(doctor);
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