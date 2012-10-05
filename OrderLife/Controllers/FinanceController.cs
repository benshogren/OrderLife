﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderLife.Models;

namespace OrderLife.Controllers
{ 
    public class FinanceController : Controller
    {
        private FinancesDBContext db = new FinancesDBContext();

        //
        // GET: /Finance/

        public ViewResult Index()
        {
            return View(db.Finances.ToList());
        }

        //
        // GET: /Finance/Details/5

        public ViewResult Details(int id)
        {
            Finances finances = db.Finances.Find(id);
            return View(finances);
        }

        //
        // GET: /Finance/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Finance/Create

        [HttpPost]
        public ActionResult Create(Finances finances)
        {
            if (ModelState.IsValid)
            {
                db.Finances.Add(finances);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(finances);
        }
        
        //
        // GET: /Finance/Edit/5
 
        public ActionResult Edit(int id)
        {
            Finances finances = db.Finances.Find(id);
            return View(finances);
        }

        //
        // POST: /Finance/Edit/5

        [HttpPost]
        public ActionResult Edit(Finances finances)
        {
            if (ModelState.IsValid)
            {
                db.Entry(finances).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(finances);
        }

        //
        // GET: /Finance/Delete/5
 
        public ActionResult Delete(int id)
        {
            Finances finances = db.Finances.Find(id);
            return View(finances);
        }

        //
        // POST: /Finance/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Finances finances = db.Finances.Find(id);
            db.Finances.Remove(finances);
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