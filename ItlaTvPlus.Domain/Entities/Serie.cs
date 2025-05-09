using ItlaTvPlus.Domain.Common;
using System.Collections.Concurrent;

namespace ItlaTvPlus.Domain.Entities
{
    public class Serie : BaseBasicEntity<int>
    {
        public string UrlImage { get; set; }

        public string UrlVideo { get; set; }

        public int ProducerId { get; set; }

        public ICollection<Gender>? Genders { get; set; }

        public Producer? Producer { get; set; }
    }
}
