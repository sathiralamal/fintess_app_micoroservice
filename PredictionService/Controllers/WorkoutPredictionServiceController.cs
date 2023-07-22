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
        public async Task<ActionResult<IEnumerable<Prediction>>> GetWorkouts(int days ,int gainCaloriesp ,int burnCaloriesp,int predDay)
        {
            int gainCalories = gainCaloriesp;
            int burnCalories = burnCaloriesp;

            //Define the current weight
            double currentWeight = 70;

            //Define the number of days in a month
            int daysInMonth = predDay;

            //Define a list to store the predicted weights
            List<double> predictedWeights = new List<double>();

            //Loop through the days in a month
            for (int i = 0; i < daysInMonth; i++)
            {
                //Calculate the net calories for each day
                int netCalories = gainCalories - burnCalories;

                //Calculate the weight change for each day
                double weightChange = netCalories / (1100.0* days);

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