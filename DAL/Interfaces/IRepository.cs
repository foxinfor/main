namespace DAL.Interfaces
{
    public interface IRepository<T>
    {
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
    }
}
