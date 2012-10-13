using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderLife.Views.DailyDiet.ViewModels {
    public class DietViewModel {
        public int ID { get; set; }
        public string StartDate { get; set; }
        public string Goals { get; set; }
        public string Method { get; set; } 
    }
}