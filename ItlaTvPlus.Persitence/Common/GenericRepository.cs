using ItlaTvPlus.Application.InterfaceRepositories.Common;
using ItlaTvPlus.Persitence.Context;
using Microsoft.EntityFrameworkCore;

namespace ItlaTvPlus.Persitence.Common
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ItlaTvPlusContext _context;

        private readonly DbSet<T> _entity;

        public GenericRepository(DbContextOptions<ItlaTvPlusContext> options)
        {
            this._context = new(options);
            this._entity = _context.Set<T>();
        }

        public virtual async Task CreateAsync(T entity)
        {
            await _entity.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task<ICollection<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(int Id)
        {
            var entity = await _context.Set<T>().FindAsync(Id);
            return entity;
        }

        public virtual async Task UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
