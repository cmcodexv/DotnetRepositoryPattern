using DotnetRepositoryPattern.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace DotnetRepositoryPattern.Data.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> dbContextOptions) : base(dbContextOptions)
        {
            try
            {
                var databaseCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
                if (databaseCreator != null)
                {
                    if (!databaseCreator.CanConnect()) databaseCreator.Create();
                    if (!databaseCreator.HasTables())
                    {
                        databaseCreator.CreateTables();
                        Console.WriteLine("---DATABASE CREATED!---");
                        Console.WriteLine("---INSERT WEATHER DATA!---");
                        var weather = new Weather { Date = DateTime.Now, TemperatureC = Random.Shared.Next(-20, 55), Summary = "Data from dotnet/mssql docker" };
                        Weathers.Add(weather);
                        SaveChanges();
                        Console.WriteLine("---DATA WEATHER CREATED!---");

                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public DbSet<Weather> Weathers { get; set; } = null!;
    }
}