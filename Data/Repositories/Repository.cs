using System;
using System.Linq;
using System.Threading.Tasks;
using DotnetRepositoryPattern.Data.Models;

namespace DotnetRepositoryPattern.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        protected readonly DatabaseContext DatabaseContext;
        public Repository(DatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }
        public IQueryable<TEntity> GetAll()
        {
            try
            {
                return DatabaseContext.Set<TEntity>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }
    }
}