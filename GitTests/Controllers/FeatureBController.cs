using Microsoft.AspNetCore.Mvc;

namespace GitTests.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FeatureBController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Bracing", "Chilly", "Cool", "Warm", "Balmy", "Hot", "Sweltering"
        };

        private readonly ILogger<FeatureBController> _logger;

        public FeatureBController(ILogger<FeatureBController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetFeatureB")]
        public IEnumerable<WeatherForecast> GetFeatureB()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}