using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderLife.Views.Health.ViewModels {
    public class ExerciseViewModel
    {
        public int ID { get; set; }
        public int Day { get; set; }
        public int Time { get; set; }
        public string Exercise { get; set; }
        public string DayName;
    }
}