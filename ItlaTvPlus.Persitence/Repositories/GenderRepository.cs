using ItlaTvPlus.Application.InterfaceRepositories.Interfaces;
using ItlaTvPlus.Domain.Entities;
using ItlaTvPlus.Persitence.Common;
using ItlaTvPlus.Persitence.Context;
using Microsoft.EntityFrameworkCore;

namespace ItlaTvPlus.Persitence.Repositories
{
    public class GenderRepository : GenericRepository<Gender>, IGenderRepository
    {

        private readonly ItlaTvPlusContext _context;

        public GenderRepository(DbContextOptions<ItlaTvPlusContext> options) : base(options)
        {
            this._context = new(options);
        }

        public override async Task<ICollection<Gender>> GetAllAsync()
        {
            var entity = await _context.Set<Gender>().Where(g => g.Remuve == false).ToListAsync();
            return entity;
        }

        public Task<ICollection<Gender>> GetGendersWithSeries()
        {
            throw new NotImplementedException();
        }
    }
}
