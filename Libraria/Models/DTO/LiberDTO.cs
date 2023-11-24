using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Libraria.Models.DTO
{
    public class LiberDTO
    {

        [Required]
        [System.ComponentModel.DataAnnotations.Key]
        public Guid ID { get; set; }
        [Required]
        public string Titulli { get; set; }
        [Required]
        public string Autori { get; set; }
        [Required]
        public string Pershkrimi { get; set; }
        public DateTime? DataRegj { get; set; }


    }
}
