namespace DotnetRepositoryPattern.Data.Repositories
{
    public interface IRepository<Weather> where Weather : class, new()
    {
        IEnumerable<Weather> GetAll();
    }
}