using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libraria.Models.DTO
{
    public class KtheLiberDTO
    {
        public List<Guid> LibratId { get; set; }
        public string EmerLexuesi { get; set; }
        public string MbiemerLexuesi { get; set; }
        public DateTime? DitelindjaLexuesit { get; set; }
    }
}
