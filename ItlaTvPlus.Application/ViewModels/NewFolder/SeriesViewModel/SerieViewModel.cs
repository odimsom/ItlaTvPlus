using ItlaTvPlus.Domain.Entities;

namespace ItlaTvPlus.Application.ViewModels.NewFolder.SeriesViewModel
{
    public class SerieViewModel
    {
        public  int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool? Remuve { get; set; }

        public string UrlImage { get; set; }

        public string UrlVideo { get; set; }

        public int ProducerId { get; set; }

        public Producer? Producer { get; set; }

        public ICollection<Gender> Genders { get; set; }
    }
}
