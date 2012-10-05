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
  
               new Finances {   Room = 700,
                                GasHouse = 75,
                                Electricity = 100,
                                Water = 40,
                                OtherUtilities = 0,
                                CarPayment = 130,
                                CarInsurance = 75,
                                GasCar = 75,
                                PublicTransportation = 0,
                                OtherTransportation = 0,
                                CellPhone = 30,
                                HousePhone = 0,
                                TVPlan = 20,
                                Internet = 40,
                                OtherMedia = 0,
                                LoanPayments = 120,
                                OtherMonthlyLoanPayments = 0,
                                Other = 0,
                                Food = 200,
                                Income = 2500}
             };

            Finances.ForEach(d => context.Finances.Add(d));
        }
    }
}