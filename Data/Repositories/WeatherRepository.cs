using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using DotnetRepositoryPattern.Data.Models;

namespace DotnetRepositoryPattern.Data.Repositories
{
    public class WeatherRepository : Repository<Weather>, IWeatherRepository
    {
        public WeatherRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
        public async Task<List<Weather>> GetWeatherAsync()
        {
            return await GetAll().ToListAsync();
        }
    }
}