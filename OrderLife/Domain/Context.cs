using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OrderLife.Models;

namespace OrderLife.Domain {
    public class AllDBContext : DbContext {
        public DbSet<Appointments> Appointments { get; set; }
        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<DailyDiet> DailyDiet { get; set; }
        public DbSet<DailyDietEntry> DailyDietEntry { get; set; }
        public DbSet<WorkoutDescription> WorkoutDescription { get; set; }
        public DbSet<Finances> Finances { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Exercises> Exercises { get; set; }
        public DbSet<Hobbies> Hobbies { get; set; }
        public DbSet<Recipes> Recipes { get; set; }
        public DbSet<Medications> Medications { get; set; }
        public DbSet<WeeklyDietEntry> WeeklyDietEntry { get; set; }

    }
}