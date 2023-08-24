using System.Collections.Generic;
using System.Threading.Tasks;

using DotnetRepositoryPattern.Data.Models;

namespace DotnetRepositoryPattern.Data.Repositories
{
    public class WeatherRepository : Repository<Weather>, IWeatherRepository
    {
        // public WeatherRepository(RepositoryPatternDemoContext repositoryPatternDemoContext) : base(repositoryPatternDemoContext)
        // {
        // }
        public IEnumerable<Weather> GetWeatherAsync()
        {
            return GetAll().ToList();
        }
    }
}