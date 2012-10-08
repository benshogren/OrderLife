using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OrderLife.Views.Time.ViewModel;


namespace OrderLife.Models
{
    public class Appointments
    {
        public int ID { get; set; }
        public int Day { get; set; }
        public int Time { get; set; }
        public string AppointmentValue { get; set; }
        public string DayName { get; set; }
    }
    public class AppointmentsDBContext : DbContext
    {
        public DbSet<Appointments> Appointments { get; set; }
        //public DbSet<Time> Time { get; set; }
    }
}