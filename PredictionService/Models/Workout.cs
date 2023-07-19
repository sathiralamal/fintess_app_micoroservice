using System;
using FitnessApplication.Models;

namespace PredictionService.Models
{
    public class Workout
    {

        public int Id { get; set; }
        public float TotalCalories { get; set; }
        public DateTime dateTime { get; set; }
        public List<Exercise>? Exercises { get; set; }
        public bool IsRecursive { get; set; }

    }
}

