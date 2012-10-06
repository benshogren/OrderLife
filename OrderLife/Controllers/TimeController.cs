using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderLife.Models;
using OrderLife.Views.Time.ViewModel;
using OrderLife.Domain;

namespace OrderLife.Controllers
{ 
    public class TimeController : Controller
    {
        private AppointmentsDBContext db = new AppointmentsDBContext();

        //
        // GET: /Time/

        public ViewResult Index()
        {
            var appointments = db.Appointments.ToList();
            var appviewmodels = new List<AppointmentViewModel>();

            foreach (var appointment in appointments) { 
                var a = new AppointmentViewModel();
                a.Day = appointment.Day;
                a.Time = appointment.Time;
                a.AppointmentValue = appointment.AppointmentValue;
                a.ID = appointment.ID;
                a.DayName = new DatePretty().Prettify(a.Day);
                appviewmodels.Add(a);
            }
            
            return View(appviewmodels);
        }

        //
        // GET: /Time/Details/5

        public ViewResult Details(int id)
        {
            Appointments appointments = db.Appointments.Find(id);
            return View(appointments);
        }

        //
        // GET: /Time/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Time/Create

        [HttpPost]
        public ActionResult Create(Appointments appointments)
        {
            if (ModelState.IsValid)
            {
                db.Appointments.Add(appointments);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(appointments);
        }
        
        //
        // GET: /Time/Edit/5
 
        public ActionResult Edit(int id)
        {
            Appointments appointments = db.Appointments.Find(id);
            return View(appointments);
        }

        //
        // POST: /Time/Edit/5

        [HttpPost]
        public ActionResult Edit(Appointments appointments)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appointments).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(appointments);
        }

        //
        // GET: /Time/Delete/5
 
        public ActionResult Delete(int id)
        {
            Appointments appointments = db.Appointments.Find(id);
            return View(appointments);
        }

        //
        // POST: /Time/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Appointments appointments = db.Appointments.Find(id);
            db.Appointments.Remove(appointments);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    

        [HttpPost, ActionName("Next")]
        public ActionResult DeleteConfirmed()
        {
            bool action;
            action = false;
            return RedirectToAction("Index");
        }
    }
}