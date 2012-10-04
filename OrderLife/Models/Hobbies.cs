﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OrderLife.Models
{
    public class Hobbies
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Journal { get; set; }
    }
    public class HobbiesDBContext : DbContext
    {
        public DbSet<Hobbies> Hobbies { get; set; }
    }
}