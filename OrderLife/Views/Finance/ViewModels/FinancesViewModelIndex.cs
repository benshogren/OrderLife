using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrderLife.Models;

namespace OrderLife.Views.Finance.ViewModels {
    public class FinancesViewModelIndex {
        public List<FinancesViewModel> finances;
        public FinancesViewModel[,] budgetviewmodel;
    }
}