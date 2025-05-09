namespace ItlaTvPlus.Application.InterfaceRepositories.Common
{
    public interface IGenericRepository<T> where T : class
    {
        Task<ICollection<T>> GetAllAsync();
        Task<T> GetByIdAsync(int Id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
    }
}
