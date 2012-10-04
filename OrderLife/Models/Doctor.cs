﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace OrderLife.Models
{
    public class Doctor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Practice { get; set; }
        public string Phone { get; set; }
        public string NextAppointment { get; set; }
    }
    public class DoctorDBContext : DbContext
    {
        public DbSet<Doctor> Doctor { get; set; }
    }
}