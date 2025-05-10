using ItlaTvPlus.Application.InterfaceRepositories.Interfaces;
using ItlaTvPlus.Domain.Entities;
using ItlaTvPlus.Persitence.Common;
using ItlaTvPlus.Persitence.Context;
using Microsoft.EntityFrameworkCore;

namespace ItlaTvPlus.Persitence.Repositories
{
    public class SerieRepository : GenericRepository<Serie>, ISerieRepository
    {
        private readonly ItlaTvPlusContext _context;

        public SerieRepository(DbContextOptions<ItlaTvPlusContext> options) : base(options)
        {
            this._context = new(options);
        }

        public Task EditSerieWithGEnders(Serie serieEditada, List<int> NewGendersId)
        {
            throw new NotImplementedException();
        }

        public override async Task<ICollection<Serie>> GetAllAsync()
        {
            var entity = await _context.Set<Serie>().Where(g => g.Remuve == false).ToListAsync();
            return entity;
        }

        public async Task<ICollection<Serie>> GetSeriesWithGenders()
        {
            var series_With_Genders = await _context
                .Series
                .Include(s => s.SerieGenders)
                .ThenInclude(sg => sg.Gender)
                .ToListAsync();
            return series_With_Genders;
        }

        public Task<Serie> GetSerieWithGenders(int id)
        {
            throw new NotImplementedException();
        }

        public async Task SaveSeriesWithGenders(Serie serie, List<int> gendersId)
        {
            await base.CreateAsync(serie);

            var realtion = gendersId.Select(id => new SeriesGenders
            {
                SerieId = serie.Id,
                GenderId = id
            });

            await _context.SeriesGenders.AddRangeAsync(realtion);
            await _context.SaveChangesAsync();
        }
    }
}
