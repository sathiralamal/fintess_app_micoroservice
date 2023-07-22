using System;
namespace PredictionService.Models
{
	public class Prediction
	{
        public int Id { get; set; }
        public string Message { get; set; }
        public List<double>? Values { get; set; }
    }
}

