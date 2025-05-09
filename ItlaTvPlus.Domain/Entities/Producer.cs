using ItlaTvPlus.Domain.Common;

namespace ItlaTvPlus.Domain.Entities
{
    public class Producer : BaseBasicEntity<int>
    {
        public ICollection<Serie>? Series { get; set; }
    }
}
