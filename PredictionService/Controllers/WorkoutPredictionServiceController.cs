using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PredictionService.Models;

namespace PredictionService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutPredictionServiceController : Controller
    {
        [Route("weightPrediction")]
        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Prediction>>> GetWorkouts(int days)
        {
            List<int> gainCalories = new List<int>() { 2000, 2500, 1800, 1900, 2100, 2300, 2200 };
            List<int> burnCalories = new List<int>() { 1500, 1700, 1600, 1400, 1800, 1900, 2000 };

            //Define the current weight
            double currentWeight = 70;

            //Define the number of days in a month
            int daysInMonth = days;

            //Define a list to store the predicted weights
            List<double> predictedWeights = new List<double>();

            //Loop through the days in a month
            for (int i = 0; i < daysInMonth; i++)
            {
                //Calculate the net calories for each day
                int netCalories = gainCalories[i % gainCalories.Count] - burnCalories[i % burnCalories.Count];

                //Calculate the weight change for each day
                double weightChange = netCalories / 7700.0;

                //Update the current weight
                currentWeight += weightChange;

                //Add the current weight to the predicted weights list
                predictedWeights.Add(currentWeight);
            }

            //Print the predicted weights list

            Prediction pred = new Prediction();
            pred.Id = 1;
            pred.Message = "WEIGHT_PREDICTION";
            pred.Values = predictedWeights;


            List<Prediction> lisobj = new List<Prediction>
            {
                pred
            };
            return lisobj;
        }

    }
}