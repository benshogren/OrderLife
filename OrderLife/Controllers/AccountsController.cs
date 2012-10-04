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
    public class AccountsController : Controller
    {
        private AccountsDBContext db = new AccountsDBContext();

        //
        // GET: /Accounts/

        public ViewResult Index()
        {
            return View(db.Accounts.ToList());
        }

        //
        // GET: /Accounts/Details/5

        public ViewResult Details(int id)
        {
            Accounts accounts = db.Accounts.Find(id);
            return View(accounts);
        }

        //
        // GET: /Accounts/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Accounts/Create

        [HttpPost]
        public ActionResult Create(Accounts accounts)
        {
            if (ModelState.IsValid)
            {
                db.Accounts.Add(accounts);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(accounts);
        }
        
        //
        // GET: /Accounts/Edit/5
 
        public ActionResult Edit(int id)
        {
            Accounts accounts = db.Accounts.Find(id);
            return View(accounts);
        }

        //
        // POST: /Accounts/Edit/5

        [HttpPost]
        public ActionResult Edit(Accounts accounts)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accounts).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accounts);
        }

        //
        // GET: /Accounts/Delete/5
 
        public ActionResult Delete(int id)
        {
            Accounts accounts = db.Accounts.Find(id);
            return View(accounts);
        }

        //
        // POST: /Accounts/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Accounts accounts = db.Accounts.Find(id);
            db.Accounts.Remove(accounts);
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