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
        public decimal Utilities { get; set; }
        public decimal Transportation { get; set; }
        public decimal Media { get; set; }
        public decimal Debt { get; set; }
        public decimal Other { get; set; }
        public decimal Food { get; set; }
        public decimal Income { get; set; }

        public decimal LeftOver()
        {
            return new FinanceCalc().Calculate(Room, Utilities, Transportation, Media, Debt, Other, Food, Income);
        }
    }
    public class FinancesDBContext : DbContext
    {
        public DbSet<Finances> Finances { get; set; }
    }
}
