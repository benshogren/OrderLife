using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace OrderLife.Models
{
    public class DoctorInitializer : DropCreateDatabaseIfModelChanges<DoctorDBContext>
    {
        protected override void Seed(DoctorDBContext context)
        {
            var Doctor = new List<Doctor> {  
  
                 new Doctor {Name = "Sir Thomas Kincaid",
                             Practice = "Orthopraxia",
                             Phone = 611111,
                             NextApp = new DateTime(1999, 6, 1)
                 },
                 new Doctor {Name = "Sir Thomas Kincaid",
                             Practice = "Orthopraxia",
                             Phone = 611111,
                             NextApp = new DateTime(1999, 6, 1)
                 }
                                              
         };
            Doctor.ForEach(d => context.Doctor.Add(d));
        }
    }
}