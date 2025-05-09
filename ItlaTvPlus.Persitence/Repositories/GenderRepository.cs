using ItlaTvPlus.Application.InterfaceRepositories.Interfaces;
using ItlaTvPlus.Domain.Entities;
using ItlaTvPlus.Persitence.Common;
using ItlaTvPlus.Persitence.Context;
using Microsoft.EntityFrameworkCore;

namespace ItlaTvPlus.Persitence.Repositories
{
    public class GenderRepository : GenericRepository<Gender>, IGenderRepository
    {
        public GenderRepository(DbContextOptions<ItlaTvPlusContext> options) : base(options)
        {
        }
    }
}
