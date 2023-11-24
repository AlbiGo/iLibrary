using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Libraria.Entity.Entities
{
    public class Inventari
    {
        [Required]
        [System.ComponentModel.DataAnnotations.Key]
        public Guid ID { get; set; }
        [ForeignKey("Librat")]
        public Guid LiberId { get; set; }
        public int? SasiaNeMagazine { get; set; }

        public bool NevojePerFurnuzim { get; set; }

        public virtual Liber Liber { get; set; }
    }
}
