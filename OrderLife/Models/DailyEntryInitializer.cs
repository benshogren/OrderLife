using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace OrderLife.Models {
    public class DailyEntryInitializer : DropCreateDatabaseIfModelChanges<DailyDietEntryDBContext> {
        protected override void Seed(DailyDietEntryDBContext context) {
            var DailyEntry = new List<DailyDietEntry> {  
  
                 new DailyDietEntry {Time = "thom",
                                    Entry = "thomas"
                 },
                 new DailyDietEntry {Time = "seed",
                                    Entry = "thomas"
                 }
                                              
         };
            DailyEntry.ForEach(d => context.DailyDietEntry.Add(d));
        }
    }
}