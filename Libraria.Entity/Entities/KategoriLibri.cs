using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Libraria.Entity.Entities
{
    public class KategoriLibri
    {

        [Required]
        [System.ComponentModel.DataAnnotations.Key]
        public Guid ID { get; set; }
        [Required]
        public string Pershkrimi { get; set; }



    }
}
