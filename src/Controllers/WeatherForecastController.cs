using Microsoft.AspNetCore.Mvc;

namespace demoapp.Controllers;

[ApiController]
[Route("wf")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public WeatherForecastController()
    {
    }

    [HttpGet]
    public string Get()
    {
        return String.Join("\n",
            Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).Select(x => x.ToString()).ToArray());
        
    }
}
