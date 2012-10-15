using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OrderLife.Models
{
    public class DailyDietEntry
    {
        public int ID { get; set; }
        public string Time { get; set; }
        public string Entry { get; set; }
    }

}