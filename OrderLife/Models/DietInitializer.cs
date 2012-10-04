using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace OrderLife.Models
{
    public class DailyDietInitializer : DropCreateDatabaseIfModelChanges<DailyDietDBContext>
    {
        protected override void Seed(DailyDietDBContext context)
        {
            var DailyDiet = new List<DailyDiet> {  
  
                 new DailyDiet {StartDate = "May the Forth",
                                Goals = "To build muscle",
                                Method = "Anaerobic weight lifting"
                 },
                 new DailyDiet {StartDate = "May the Fourth",
                                Goals = "To lose fat and build muscle",
                                Method = "Anaerobic weight lifting and some anaerobic cardio"
                 }
                                              
         };
            DailyDiet.ForEach(d => context.DailyDiet.Add(d));
        }
    }
}