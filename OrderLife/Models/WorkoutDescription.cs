using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OrderLife.Models
{
    public class WorkoutDescription
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

}