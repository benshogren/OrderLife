using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OrderLife.Domain;

namespace OrderLife.Models
{
    public class Finances
    {
        public int ID { get; set; }
        public decimal Room { get; set; } 
        public decimal GasHouse { get; set; }
        public decimal Electricity { get; set; }
        public decimal Water { get; set; }
        public decimal OtherUtilities { get; set; }
        public decimal CarPayment { get; set; }
        public decimal CarInsurance { get; set; }
        public decimal GasCar { get; set; }
        public decimal PublicTransportation { get; set; }
        public decimal OtherTransportation { get; set; }
        public decimal CellPhone { get; set; }
        public decimal HousePhone { get; set; }
        public decimal TVPlan { get; set; }
        public decimal Internet { get; set; }
        public decimal OtherMedia { get; set; }
        public decimal LoanPayments { get; set; }
        public decimal OtherMonthlyLoanPayments { get; set; }
        public decimal Other { get; set; }
        public decimal Food { get; set; }
        public decimal Income { get; set; }

    }

}
