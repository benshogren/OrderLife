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
    public class RecipesController : Controller
    {
        private AllDBContext db = new AllDBContext();

        //
        // GET: /Recipes/

        public ViewResult Index()
        {
            return View(db.Recipes.ToList());
        }

        //
        // GET: /Recipes/Details/5

        public ViewResult Details(int id)
        {
            Recipes recipes = db.Recipes.Find(id);
            return View(recipes);
        }

        //
        // GET: /Recipes/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Recipes/Create

        [HttpPost]
        public ActionResult Create(Recipes recipes)
        {
            if (ModelState.IsValid)
            {
                db.Recipes.Add(recipes);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(recipes);
        }
        
        //
        // GET: /Recipes/Edit/5
 
        public ActionResult Edit(int id)
        {
            Recipes recipes = db.Recipes.Find(id);
            return View(recipes);
        }

        //
        // POST: /Recipes/Edit/5

        [HttpPost]
        public ActionResult Edit(Recipes recipes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recipes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recipes);
        }

        //
        // GET: /Recipes/Delete/5
 
        public ActionResult Delete(int id)
        {
            Recipes recipes = db.Recipes.Find(id);
            return View(recipes);
        }

        //
        // POST: /Recipes/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Recipes recipes = db.Recipes.Find(id);
            db.Recipes.Remove(recipes);
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