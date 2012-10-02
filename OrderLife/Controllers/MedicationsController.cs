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
    public class MedicationsController : Controller
    {
        private MedicationsDBContext db = new MedicationsDBContext();

        //
        // GET: /Medications/

        public ViewResult Index()
        {
            return View(db.Medications.ToList());
        }

        //
        // GET: /Medications/Details/5

        public ViewResult Details(int id)
        {
            Medications medications = db.Medications.Find(id);
            return View(medications);
        }

        //
        // GET: /Medications/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Medications/Create

        [HttpPost]
        public ActionResult Create(Medications medications)
        {
            if (ModelState.IsValid)
            {
                db.Medications.Add(medications);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(medications);
        }
        
        //
        // GET: /Medications/Edit/5
 
        public ActionResult Edit(int id)
        {
            Medications medications = db.Medications.Find(id);
            return View(medications);
        }

        //
        // POST: /Medications/Edit/5

        [HttpPost]
        public ActionResult Edit(Medications medications)
        {
            if (ModelState.IsValid)
            {
                db.Entry(medications).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(medications);
        }

        //
        // GET: /Medications/Delete/5
 
        public ActionResult Delete(int id)
        {
            Medications medications = db.Medications.Find(id);
            return View(medications);
        }

        //
        // POST: /Medications/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Medications medications = db.Medications.Find(id);
            db.Medications.Remove(medications);
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