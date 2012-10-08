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
using System.Text;

namespace OrderLife.Controllers
{ 
    public class TimeController : Controller
    {
        private AppointmentsDBContext appDb = new AppointmentsDBContext();
        private HobbiesDBContext hdDb = new HobbiesDBContext();

        //
        // GET: /Time/
        public ViewResult Index(int Step = 1)
        {
            var appointments = appDb.Appointments.ToList();
            var hobbies = hdDb.Hobbies.ToList();
            var appviewmodels = new List<AppointmentViewModel>();
            var calData = new AppointmentViewModel[7, 24];
            foreach (var appointment in appointments) { 
                var a = new AppointmentViewModel();
                a.Day = appointment.Day;
                a.Time = appointment.Time;
                a.AppointmentValue = appointment.AppointmentValue;
                a.ID = appointment.ID;
                a.DayName = new DatePretty().Prettify(a.Day);
                appviewmodels.Add(a);
                calData[a.Day-1, a.Time] = a;
            }
            
            var vms = new AppointmentIndexViewModel();
            vms.appointments = appviewmodels;
            vms.hobbies = hobbies;
            vms.calendarTableData = calData;
            vms.Step = Step;
            return View(vms);
        }

        //
        // GET: /Time/Details/5
        public ViewResult Details(int id)
        {
            Appointments appointments = appDb.Appointments.Find(id);
            return View(appointments);
        }

        //
        // GET: /Time/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        public ActionResult Create(int Day, int Time) {
            var Apps = new Appointments();
            Apps.Day = Day;
            Apps.Time = Time; 
            Apps.DayName = new DatePretty().Prettify(Day);
            return View(Apps);
        } 

        //
        // POST: /Time/Create
        [HttpPost]
        public ActionResult Create(Appointments appointments)
        {
            if (ModelState.IsValid)
            {
                appDb.Appointments.Add(appointments);
                appDb.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(appointments);
        }
        
        //
        // GET: /Time/Edit/5
 
        public ActionResult Edit(int id)
        {
            Appointments appointments = appDb.Appointments.Find(id);
            return View(appointments);
        }

        //
        // POST: /Time/Edit/5

        [HttpPost]
        public ActionResult Edit(Appointments appointments)
        {
            if (ModelState.IsValid)
            {
                appDb.Entry(appointments).State = EntityState.Modified;
                appDb.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(appointments);
        }

        //
        // GET: /Time/Delete/5
 
        public ActionResult Delete(int id)
        {
            Appointments appointments = appDb.Appointments.Find(id);
            return View(appointments);
        }

        //
        // POST: /Time/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Appointments appointments = appDb.Appointments.Find(id);
            appDb.Appointments.Remove(appointments);
            appDb.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            appDb.Dispose();
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