﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderLife.Views.DailyDiet.ViewModels {
    public class DailyDietEntryViewModel {
        public int ID { get; set; }
        public int Time { get; set; }
        public string Entry { get; set; }
    }
}