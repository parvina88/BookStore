namespace Domain.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity: class
    {
        Task<TEntity> GetAsync(Guid id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> InsertAsync(TEntity entity);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> UpdateAsync(TEntity entity);
    }
}
