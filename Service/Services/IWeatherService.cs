using System.Collections.Generic;
using System.Threading.Tasks;
using DotnetRepositoryPattern.Data.Models;

namespace DotnetRepositoryPattern.Service.Services
{
    public interface IWeatherService
    {
        IEnumerable<Weather> GetWeatherAsync();
    }
}