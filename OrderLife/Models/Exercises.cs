using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OrderLife.Models
{
    public class Exercises
    {
        public int ID { get; set; }
        public int Day { get; set; }
        public int Time { get; set; }
        public string AppointmentValue { get; set; }

    }
    public class ExercisesDBContext : DbContext
    {
        public DbSet<Exercises> Exercises { get; set; }
    }
}