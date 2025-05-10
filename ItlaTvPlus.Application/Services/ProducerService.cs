using ItlaTvPlus.Application.InterfaceRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ItlaTvPlus.Application.Services
{
    public class ProducerService
    {
        private readonly IProducerRepsitory _repository;

        public ProducerService(IProducerRepsitory repository)
        {
            this._repository = repository;
        }
    }
}
