using System.Collections.Generic;
using System.Threading.Tasks;
using DotnetRepositoryPattern.Data.Models;

namespace DotnetRepositoryPattern.Data.Repositories
{
    public interface IWeatherRepository : IRepository<Weather>
    {
        IEnumerable<Weather> GetWeatherAsync();
    }
}