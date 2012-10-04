﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OrderLife.Models
{
    public class WeeklyDiet
    {
        public int ID { get; set; }
        public string StartDate { get; set; }
        public string Goals { get; set; }

    }
    public class WeeklyDietDBContext : DbContext
    {
        public DbSet<WeeklyDiet> WeeklyDiet { get; set; }
    }
}