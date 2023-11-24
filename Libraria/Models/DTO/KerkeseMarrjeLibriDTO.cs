using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libraria.Models.DTO
{
    public class KerkeseMarrjeLibriDTO
    {
        public List<Guid> LiberId { get; set; }
        public DateTime? DataMarrjes { get; set; }
        public DateTime? DataKthimit { get; set; }
    }
}
