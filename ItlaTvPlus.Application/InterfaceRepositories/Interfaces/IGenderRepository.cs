using ItlaTvPlus.Application.InterfaceRepositories.Common;
using ItlaTvPlus.Application.Services;
using ItlaTvPlus.Domain.Entities;

namespace ItlaTvPlus.Application.InterfaceRepositories.Interfaces
{
    public interface IGenderRepository : IGenericRepository<Gender>
    {
        Task<ICollection<Gender>> GetGendersWithSeries(); 
    }
}
