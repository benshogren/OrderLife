using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace OrderLife.Models {
    public class WorkoutInitialized : DropCreateDatabaseIfModelChanges<WorkoutDescriptionDBContext> {
        protected override void Seed(WorkoutDescriptionDBContext context) {
            var Workouts = new List<WorkoutDescription> {  
  
                 new WorkoutDescription { Name = "My Workout",
                                          Description = "Lost fat, build muscle"
                 }
                
 
             };

            Workouts.ForEach(d => context.WorkoutDescription.Add(d));
        }
    }
}