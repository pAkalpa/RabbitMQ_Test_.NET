using Microsoft.AspNetCore.Mvc;
using RabbitMQTest.RabbitMQ;

namespace RabbitMQTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly IRabbitMQProducer _producer;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IRabbitMQProducer rabbitMQProducer)
        {
            _logger = logger;
            _producer = rabbitMQProducer;
        }

        [HttpGet("GetWeatherForecast/")]
        public IActionResult Get(string message)
        {
            _producer.SendProductMessage(message);
            return Ok();
        }
    }
}