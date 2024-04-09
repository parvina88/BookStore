using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private ApplicationDbContext _context;

        protected BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetAsync(Guid id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<bool> UpdateAsync(TEntity entity)
        {
           _context.Update(entity);
           return await _context.SaveChangesAsync() > 0;

       
        }
        public async Task<bool> DeleteAsync(Guid id)
        {
            var entityToUpdate = GetAsync(id);
            
            if (entityToUpdate != null)
            {
                _context.Remove(entityToUpdate);
            }

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
