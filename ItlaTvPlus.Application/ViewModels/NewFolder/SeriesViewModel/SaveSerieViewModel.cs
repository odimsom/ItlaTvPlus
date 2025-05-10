using ItlaTvPlus.Domain.Entities;

namespace ItlaTvPlus.Application.ViewModels.NewFolder.SeriesViewModel
{
    public class SaveSerieViewModel
    {
        public SerieViewModel Serie { get; set; }

        public ICollection<Gender>? Genders { get; set; }

        public List<int> GendersId { get; set; }
    }
}
