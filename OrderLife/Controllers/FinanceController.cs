using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderLife.Models;
using OrderLife.Views.Finance.ViewModels;

namespace OrderLife.Controllers
{ 
    public class FinanceController : Controller
    {
        private FinancesDBContext db = new FinancesDBContext();

        //
        // GET: /Finance/

        public ViewResult Index(int Step = 1) {
            var financebudgetlist = db.Finances.ToList();
            var financesviewmods = new List<FinancesViewModel>();
            
            foreach (var budget in financebudgetlist) {
                var FViewMod = new FinancesViewModel();
                    FViewMod.ID = budget.ID;
                    FViewMod.Room = budget.Room;
                    FViewMod.GasHouse = budget.GasHouse;
                    FViewMod.Electricity = budget.Electricity;
                    FViewMod.Water = budget.Water;
                    FViewMod.OtherUtilities = budget.OtherUtilities;
                    FViewMod.CarPayment = budget.CarPayment;
                    FViewMod.CarInsurance = budget.CarInsurance;
                    FViewMod.GasCar = budget.GasCar;
                    FViewMod.PublicTransportation = budget.PublicTransportation;
                    FViewMod.OtherTransportation = budget.OtherTransportation;
                    FViewMod.CellPhone = budget.CellPhone;
                    FViewMod.HousePhone = budget.HousePhone;
                    FViewMod.TVPlan = budget.TVPlan;
                    FViewMod.Internet = budget.Internet;
                    FViewMod.OtherMedia = budget.OtherMedia;
                    FViewMod.LoanPayments = budget.LoanPayments;
                    FViewMod.OtherMonthlyLoanPayments = budget.OtherMonthlyLoanPayments;
                    FViewMod.Other = budget.Other;
                    FViewMod.Food = budget.Food;
                    FViewMod.Income = budget.Income;
                financesviewmods.Add(FViewMod);
            }

            var financeVMIndex = new FinancesViewModelIndex();
            financeVMIndex.finances = financesviewmods;
            //financeVMIndex.budgetviewmodel = ViewModel;
            financeVMIndex.Step = Step;
            return View(financeVMIndex);
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