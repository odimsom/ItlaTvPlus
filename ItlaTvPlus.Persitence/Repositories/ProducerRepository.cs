using ItlaTvPlus.Application.InterfaceRepositories.Interfaces;
using ItlaTvPlus.Domain.Entities;
using ItlaTvPlus.Persitence.Common;
using ItlaTvPlus.Persitence.Context;
using Microsoft.EntityFrameworkCore;

namespace ItlaTvPlus.Persitence.Repositories
{
    public class ProducerRepository : GenericRepository<Producer>, IProducerRepsitory
    {
        public ProducerRepository(DbContextOptions<ItlaTvPlusContext> options) : base(options)
        {
        }
    }
}
