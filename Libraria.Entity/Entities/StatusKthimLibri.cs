using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Libraria.Entity.Entities
{
    public class StatusKthimLibri
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Pershkrimi { get; set; }
    }
}
