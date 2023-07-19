using System;
using System.Text.Json.Serialization;
using PredictionService.Models;

namespace FitnessApplication.Models
{
	public class Exercise
	{
        public int Id { get; set; }
        public string ExerciseName { get; set; } = null!;
        public string? ExerciseDescription { get; set; }
        public float Calories { get; set; }
        [JsonIgnore]
        public List<Workout>? Workouts { get; set; }
    }
}

