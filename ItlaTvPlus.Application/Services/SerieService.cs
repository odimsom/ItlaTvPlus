using ItlaTvPlus.Application.InterfaceRepositories.Interfaces;
using ItlaTvPlus.Application.ViewModels.NewFolder.SeriesViewModel;
using ItlaTvPlus.Domain.Entities;

namespace ItlaTvPlus.Application.Services
{
    public class SerieService
    {
        private readonly ISerieRepository _repository;
        private readonly IGenderRepository _genderRepository;

        public SerieService(ISerieRepository repository, IGenderRepository genderRepository)
        {
            this._repository = repository;
            this._genderRepository = genderRepository;
        }

        public async Task<ICollection<SaveSerieViewModel>> GetSeriesWhithGenders()
        {
            var serie_Complete = await _repository.GetSeriesWithGenders();
            var vm = serie_Complete.Select(sc => new SaveSerieViewModel
            {
                Serie = new SerieViewModel
                {
                    Id = sc.Id,
                    Name = sc.Name,
                    Description = sc.Description,
                    UrlImage = sc.UrlImage,
                    UrlVideo = sc.UrlVideo,
                    Producer = sc.Producer,
                    ProducerId = sc.ProducerId,

                },
                GendersId = sc.SerieGenders.Select(sg => sg.GenderId).ToList(),
                Genders = sc.SerieGenders.Select(sg => sg.Gender).ToList()
            }).ToList();
            return vm;
        }

        public async Task<ICollection<SaveSerieViewModel>> GetSeriesWhithGendersCreate()
        {
            var genders = await _genderRepository.GetAllAsync();
            var serie_Complete = await _repository.GetSeriesWithGenders();
            var vm = serie_Complete.Select(sc => new SaveSerieViewModel
            {
                Serie = new SerieViewModel(),
                GendersId = genders.Select(g => g.Id).ToList(),
                Genders = genders
            }).ToList();
            return vm;
        }

        public async Task SaveSerieWithGenders(SerieViewModel vm, List<int> gendersId)
        {
            var serie = new Serie
            {
                Id = vm.Id,
                Name = vm.Name,
                Description = vm.Description,
                UrlImage = vm.UrlImage,
                UrlVideo = vm.UrlVideo,
                Producer = vm.Producer,
                ProducerId = vm.ProducerId,

            };
            await _repository.SaveSeriesWithGenders(serie, gendersId);
        }
    }
}
