using ItlaTvPlus.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItlaTvPlus.Domain.Entities
{
    public class Gender : BaseBasicEntity<int>
    {
        public ICollection<Serie>? Series { get; set; }
    }
}
