using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OrderLife.Domain;

namespace OrderLife.Models
{
    public class Medications
    {
        public int ID { get; set;}
        public string Name { get; set; }
        public string Dosage { get; set; }
        public string Purpose { get; set; }
        public string NextRefill { get; set; }
        public string NameOfPrescriber { get; set; }
    }
    public class MedicationsDBContext : DbContext
    {
        public DbSet<Medications> Medications { get; set; }
    }
}