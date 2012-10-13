﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderLife.Models;
using OrderLife.Views.DailyDiet.ViewModels;
using OrderLife.Domain;
using System.Text;

namespace OrderLife.Controllers {
    public class DailyDietController : Controller {
        private DailyDietDBContext ddb = new DailyDietDBContext();
        private DailyDietEntryDBContext ddeb = new DailyDietEntryDBContext();

        //
        // GET: /DailyDiet/

        public ViewResult Index() {
            var diets = ddb.DailyDiet.ToList();
            var dailyentries = ddeb.DailyDietEntry.ToList();
            var dietviewmodels = new List<DietViewModel>();
            var entryviewmodels = new List<DailyDietEntryViewModel>();
            var TableData = new DailyDietEntryViewModel[1, 24];
            foreach (var diet in diets) {
                var newVM = new DietViewModel();
                newVM.ID = diet.ID;
                newVM.StartDate = diet.StartDate;
                newVM.Goals = diet.Goals;
                newVM.Method = diet.Method;
                dietviewmodels.Add(newVM);
            }
            foreach (var entry in dailyentries) {
                var newVM = new DailyDietEntryViewModel();
                newVM.ID = entry.ID;
                newVM.Time = entry.Time;
                newVM.Entry = entry.Entry;
                //TableData[1, newVM.Time] = newVM;
                entryviewmodels.Add(newVM);
            }
            var VMIndex = new DietViewModelIndex();
            VMIndex.diet = dietviewmodels;
            VMIndex.dailyentry = entryviewmodels;
            //VMIndex.TableData = TableData;
            return View(VMIndex);
        }

        //
        // GET: /DailyDiet/Details/5

        public ViewResult Details(int id) {
            DailyDiet dailydiet = ddb.DailyDiet.Find(id);
            return View(dailydiet);
        }

        //
        // GET: /DailyDiet/Create

        public ActionResult Create(string startDate, string goals, string method) {
            var diet = new DailyDiet();
            diet.StartDate = startDate;
            diet.Goals = goals;
            diet.Method = method;
            return View(diet);
        } 

        //
        // POST: /DailyDiet/Create

        [HttpPost]
        public ActionResult Create(DailyDiet dailydiet) {
            if (ModelState.IsValid) {
                ddb.DailyDiet.Add(dailydiet);
                ddb.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dailydiet);
        }

        //
        // GET: /DailyDiet/Edit/5

        public ActionResult Edit(int id) {
            DailyDiet dailydiet = ddb.DailyDiet.Find(id);
            return View(dailydiet);
        }

        //
        // POST: /DailyDiet/Edit/5

        [HttpPost]
        public ActionResult Edit(DailyDiet dailydiet) {
            if (ModelState.IsValid) {
                ddb.Entry(dailydiet).State = EntityState.Modified;
                ddb.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dailydiet);
        }

        //
        // GET: /DailyDiet/Delete/5

        public ActionResult Delete(int id) {
            DailyDiet dailydiet = ddb.DailyDiet.Find(id);
            return View(dailydiet);
        }

        //
        // POST: /DailyDiet/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id) {
            DailyDiet dailydiet = ddb.DailyDiet.Find(id);
            ddb.DailyDiet.Remove(dailydiet);
            ddb.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing) {
            ddb.Dispose();
            base.Dispose(disposing);
        }



        //public ActionResult Create(int Day, int Time) {
        //    var Ex = new Exercises();
        //    Ex.Day = Day;
        //    Ex.Time = Time;
        //    Ex.DayName = new DatePretty().Prettify(Day);
        //    return View(Ex);
        //} 
    }
}

