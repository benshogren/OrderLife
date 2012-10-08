using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace OrderLife.Models {
    public class SchedInitializer : DropCreateDatabaseIfModelChanges<AppointmentsDBContext> {
        protected override void Seed(AppointmentsDBContext context) {
            var Sched = new List<Appointments> {  
  
                 new Appointments {
                     Day = 1,
                     Time = 2,
                     AppointmentValue = "DB",
                     DayName = "Sunday"
                 },
                 new Appointments {
                     Day = 1,
                     Time = 2,
                     AppointmentValue = "DB",
                     DayName = "Sunday"
                 }
                                              
         };
            Sched.ForEach(d => context.Appointments.Add(d));
        }
    }
}