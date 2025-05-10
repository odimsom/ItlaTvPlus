using ItlaTvPlus.Domain.Common;

namespace ItlaTvPlus.Domain.Entities
{
    public class Gender : BaseBasicEntity<int>
    {
        public ICollection<SeriesGenders> SerieGenders { get; set; }
    }
}
