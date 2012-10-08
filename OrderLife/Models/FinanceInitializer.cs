using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace OrderLife.Models
{
    public class FinanceInitializer : DropCreateDatabaseIfModelChanges<FinancesDBContext>
    {
        protected override void Seed(FinancesDBContext context)
        {
            var Finances = new List<Finances> {  
  
               new Finances {   
                                Room = 0,
                                GasHouse = 0,
                                Electricity = 0,
                                Water = 0,
                                OtherUtilities = 0,
                                CarPayment = 0,
                                CarInsurance = 0,
                                GasCar = 0,
                                PublicTransportation = 0,
                                OtherTransportation = 0,
                                CellPhone = 0,
                                HousePhone = 0,
                                TVPlan = 0,
                                Internet = 0,
                                OtherMedia = 0,
                                LoanPayments = 0,
                                OtherMonthlyLoanPayments = 0,
                                Other = 0,
                                Food = 0,
                                Income = 0}
             };

            Finances.ForEach(d => context.Finances.Add(d));
        }
    }
}