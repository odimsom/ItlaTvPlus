
namespace ItlaTvPlus.Domain.Entities
{
    public class SeriesGenders
    {
        public int SerieId { get; set; }
        public Serie? Serie { get; set; }

        public int GenderId { get; set; }
        public Gender? Gender { get; set; }
    }
}
