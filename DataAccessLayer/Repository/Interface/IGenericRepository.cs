namespace DataAccessLayer.Repository.Interface
{
    public interface IGenericRepository<T>
    {
        Task DeleteAsync(object id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(object id);
        Task InsertAsync(T entity);
        Task SaveAsync();
        void Update(T entity);
    }
}