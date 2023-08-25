using Microsoft.AspNetCore.Mvc;
using DotnetRepositoryPattern.Data.Models;
using DotnetRepositoryPattern.Service.Services;

namespace DotnetRepositoryPattern.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly IWeatherService _weatherService;
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(IWeatherService weatherService, ILogger<WeatherForecastController> logger)
    {
        _weatherService = weatherService;
        _logger = logger;
    }

    [HttpGet(Name = "GetWeather")]
     public async Task<ActionResult<List<Weather>>> GetAll()
    {
        return await _weatherService.GetWeatherAsync();
    }
}
