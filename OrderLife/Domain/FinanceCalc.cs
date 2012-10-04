using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderLife.Domain
{
    public class FinanceCalc
    {
        public decimal Calculate(decimal Room, decimal Utilities, decimal Transportation, decimal Media, decimal Debt, decimal Other,
            decimal Food, decimal Income)
        {
            return Income - (Room + Utilities + Transportation + Media + Debt + Other + Food);
        }
    }
}