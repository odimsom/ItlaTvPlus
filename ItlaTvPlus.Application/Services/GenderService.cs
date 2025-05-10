using ItlaTvPlus.Application.InterfaceRepositories.Interfaces;
using ItlaTvPlus.Application.ViewModels.NewFolder.GenderViewModels;
using ItlaTvPlus.Domain.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Runtime.InteropServices;

namespace ItlaTvPlus.Application.Services
{
    public class GenderService
    {
        private readonly IGenderRepository _repository;

        public GenderService(IGenderRepository repository)
        {
            this._repository = repository;
        }

        public async Task<ICollection<GenderViewModel>> GetAll()
        {
            var entity = await _repository.GetAllAsync();
            var vm = entity.Select(e => new GenderViewModel
            {
                Id = e.Id,
                Name = e.Name,
                Description = e.Description
            }).ToList();
            return vm;
        }

        public async Task Save(GenderViewModel vm)
        {
            var gender = new Gender
            {
                Id = vm.Id,
                Name = vm.Name,
                Description = vm.Description
            };
            await _repository.CreateAsync(gender);
        } 

        public async Task Delete(int id)
        {
            var entity =  await _repository.GetByIdAsync(id);
            entity.Remuve = true;
            await _repository.UpdateAsync(entity);
        }
    }
}
