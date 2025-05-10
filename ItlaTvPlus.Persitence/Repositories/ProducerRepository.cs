using ItlaTvPlus.Application.InterfaceRepositories.Interfaces;
using ItlaTvPlus.Domain.Entities;
using ItlaTvPlus.Persitence.Common;
using ItlaTvPlus.Persitence.Context;
using Microsoft.EntityFrameworkCore;

namespace ItlaTvPlus.Persitence.Repositories
{
    public class ProducerRepository : GenericRepository<Producer>, IProducerRepsitory
    {

        private readonly ItlaTvPlusContext _context;

        public ProducerRepository(DbContextOptions<ItlaTvPlusContext> options) : base(options)
        {
            this._context = new(options);
        }

        public override async Task<ICollection<Producer>> GetAllAsync()
        {
            var entity = await _context.Set<Producer>().Where(g => g.Remuve == false).ToListAsync();
            return entity;
        }
    }
}
