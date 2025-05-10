using ItlaTvPlus.Application.InterfaceRepositories.Common;
using ItlaTvPlus.Domain.Entities;

namespace ItlaTvPlus.Application.InterfaceRepositories.Interfaces
{
    public interface ISerieRepository : IGenericRepository<Serie>
    {
        Task<ICollection<Serie>> GetSeriesWithGenders();
        Task SaveSeriesWithGenders(Serie serie, List<int> GendersId);
        Task<Serie> GetSerieWithGenders(int id);
        Task EditSerieWithGEnders(Serie serieEditada, List<int> NewGendersId);
    }
}
