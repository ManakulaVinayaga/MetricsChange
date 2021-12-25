
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsChanges.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MetricsChangeController : ControllerBase
    {
        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        private readonly ILogger<MetricsChangeController> _logger;
        private IMetrics _metrics;

        public MetricsChangeController(ILogger<MetricsChangeController> logger,IMetrics metrics)
        {
            _metrics = metrics;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetCelciustoFahrenheit(int Value, string CorF)
        {
            return Ok(_metrics.TempratureMetrics(Value, CorF));
        }

        //[HttpGet]
        //public IEnumerable<TempModel> Get(int Cel)
        //{
        //TempModel tempModel = new TempModel();



        //return tempModel;
        ////var rng = new Random();
        //return Enumerable.Range(1, 1).Select(index => new TempModel
        //{
        //    //Date = DateTime.Now.AddDays(index),
        //    TemperatureC = Cel,//rng.Next(-20, 55),
        //                       //Summary = Summaries[rng.Next(Summaries.Length)]
        //}).ToArray();

        //}




    }
}
