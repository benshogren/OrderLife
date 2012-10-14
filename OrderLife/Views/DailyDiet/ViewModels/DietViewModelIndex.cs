using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrderLife.Models;
using OrderLife.Views.DailyDiet.ViewModels;

namespace OrderLife.Views.DailyDiet.ViewModels {
    public class DietViewModelIndex {
        public List<DietViewModel> diet;
        public List<DailyDietEntryViewModel> dailyentry;
        //public List<WeeklyDietEntryViewModel> weeklyentry;
        //public DailyDietEntryViewModel[,] TableData;
    }
}