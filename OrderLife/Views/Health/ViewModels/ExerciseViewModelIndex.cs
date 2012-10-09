using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrderLife.Models;
using OrderLife.Views.Health.ViewModels;

namespace OrderLife.Views.Health.ViewModels {
    public class ExerciseViewModelIndex 
    {
        public List<ExerciseViewModel> exercises;
        public List<WorkoutViewModel> workouts;
        public ExerciseViewModel[,] TableData;
    }
}