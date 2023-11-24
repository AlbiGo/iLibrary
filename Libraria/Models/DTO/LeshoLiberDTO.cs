using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libraria.Models.DTO
{
    public class LeshoLiberDTO
    {
        public List<Guid> LibratId { get; set; }
        public Guid LexuesId { get; set; }
        public int? TipiLeshimit { get; set; }
    }
}
