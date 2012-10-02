using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace OrderLife.Models
{
    public class ExercisesInitializer : DropCreateDatabaseIfModelChanges<ExercisesDBContext>
    {
        protected override void Seed(ExercisesDBContext context)
        {
            var Exercisess = new List<Exercises> {  
  
                 new Exercises { Time = 11,   
                             Day = 3,   
                             Exercise = "Sir Thomas Kincaid"},  
                 new Exercises { Time = 10,   
                             Day = 6,   
                             Exercise = "Sir Thomas Kincaid"},  
                new Exercises { Time = 12,   
                             Day = 1,   
                             Exercise = "Sir Thomas Kincaid"},  

 
             };

            Exercisess.ForEach(d => context.Exercises.Add(d));
        }
    }
}