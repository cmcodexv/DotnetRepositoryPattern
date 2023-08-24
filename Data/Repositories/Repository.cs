using System;
using DotnetRepositoryPattern.Data.Models;

namespace DotnetRepositoryPattern.Data.Repositories
{
    public class Repository<Weather> : IRepository<Weather> where Weather : class, new()
    {
        // protected readonly RepositoryPatternDemoContext RepositoryPatternDemoContext;
        // public Repository(RepositoryPatternDemoContext repositoryPatternDemoContext)
        // {
        //     RepositoryPatternDemoContext = repositoryPatternDemoContext;
        // }
        public IEnumerable<Weather> GetAll()
        {
            try
            {
                return null;
                //return RepositoryPatternDemoContext.Set<TEntity>();

            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }
    }
}