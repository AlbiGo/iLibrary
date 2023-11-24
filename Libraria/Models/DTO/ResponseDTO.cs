using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libraria.Models.DTO
{
    public class ResponseDTO
    {
        public int KodiDaljes { get; set; } //1 => OK , 0 => KO
        public string Pershkrim { get; set; }
    }
}
