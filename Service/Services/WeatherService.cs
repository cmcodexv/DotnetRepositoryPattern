using System.Collections.Generic;
using System.Threading.Tasks;
using DotnetRepositoryPattern.Data.Models;
using DotnetRepositoryPattern.Data.Repositories;

namespace DotnetRepositoryPattern.Service.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherRepository _weatherRepository;
        // private static readonly string[] Summaries = new[]
        // {
        // "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        // };
        public WeatherService(IWeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository;
        }

        public async Task<List<Weather>> GetWeatherAsync()
        {
            // return Enumerable.Range(1, 5).Select(index => new Weather
            // {
            //     Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //     TemperatureC = Random.Shared.Next(-20, 55),
            //     Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            // }).ToArray();
            return await _weatherRepository.GetWeatherAsync();
        }

    }
}