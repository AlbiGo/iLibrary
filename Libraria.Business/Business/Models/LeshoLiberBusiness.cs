using System;
using System.Collections.Generic;
using System.Text;

namespace Libraria.Business.Business.Models
{
    public class LeshoLiberBusiness
    {
        public List<Guid> LibratId { get; set; }
        public Guid LexuesId { get; set; }
        public Guid AprovuesId { get; set; }

        public int? TipiKthimit { get; set; }
        public int? TipiLEshimit { get; set; }
    }
}
