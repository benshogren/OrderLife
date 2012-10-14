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
    public class LoginController : Controller
    {
        private LoginDBContext db = new LoginDBContext();

        //
        // GET: /Login/

        public ViewResult Index()
        {
            return View(db.Login.ToList());
        }

        //
        // GET: /Login/Details/5

        public ViewResult Details(int id)
        {
            Login login = db.Login.Find(id);
            return View(login);
        }

        //
        // GET: /Login/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Login/Create

        [HttpPost]
        public ActionResult Create(Login login)
        {
            if (ModelState.IsValid)
            {
                db.Login.Add(login);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(login);
        }
        
        //
        // GET: /Login/Edit/5
 
        public ActionResult Edit(int id)
        {
            Login login = db.Login.Find(id);
            return View(login);
        }

        //
        // POST: /Login/Edit/5

        [HttpPost]
        public ActionResult Edit(Login login)
        {
            if (ModelState.IsValid)
            {
                db.Entry(login).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(login);
        }

        //
        // GET: /Login/Delete/5
 
        public ActionResult Delete(int id)
        {
            Login login = db.Login.Find(id);
            return View(login);
        }

        //
        // POST: /Login/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Login login = db.Login.Find(id);
            db.Login.Remove(login);
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