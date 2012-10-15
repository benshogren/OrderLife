using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OrderLife.Domain;

namespace OrderLife.Models
{
    public class Exercises
    {
        public int ID { get; set; }
        public int Day { get; set; }
        public int Time { get; set; }
        public string Exercise { get; set; }
        public string DayName;
    }

}