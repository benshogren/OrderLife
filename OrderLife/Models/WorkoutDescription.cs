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
        public int Description { get; set; }
    }
    public class WorkoutDesciptionDBContext : DbContext
    {
        public DbSet<WorkoutDescription> WorkoutDescription { get; set; }
    }
}