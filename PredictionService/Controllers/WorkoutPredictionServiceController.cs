using System;
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
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Prediction>>> GetWorkouts()
        {
            Prediction p = new Prediction();
            p.Id = 122;
            p.Message = "dsdsfsf";

            List<Prediction> lisobj = new List<Prediction>
            {
                p
            };
            return lisobj;
        }

    }
}