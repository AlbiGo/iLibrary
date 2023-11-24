using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Libraria.Entity.Entities
{
    public class TipiLeshimLibri
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Pershkrimi { get; set; }


    }
}
