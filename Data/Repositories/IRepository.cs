namespace DotnetRepositoryPattern.Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
       IQueryable<TEntity> GetAll();
    }
}