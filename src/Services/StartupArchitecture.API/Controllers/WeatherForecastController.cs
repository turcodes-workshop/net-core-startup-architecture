using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StartupArchitecture.FirstInregration.Abstracts;
using StartupArchitecture.SecondInregration.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartupArchitecture.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IFirstIntegrationBusiness _firstIntegration;
        private readonly ISecondIntegrationBusiness _secondIntegration;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
                                         IFirstIntegrationBusiness firstIntegration,
                                         ISecondIntegrationBusiness secondIntegration)
        {
            _logger = logger;
            _firstIntegration = firstIntegration;
            _secondIntegration = secondIntegration;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();

            string firstHi = _firstIntegration.SayHi();
            string secondHi = _secondIntegration.SayHi();

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
