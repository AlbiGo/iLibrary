using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Libraria.Entity.Entities
{
    public class KthimLibri
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [ForeignKey("MarrjeLibri")]
        public Guid? MarrjeLIbri { get; set; }
        public DateTime? DataKthimit { get; set; }
        [ForeignKey("StatusKthimLibri")]
        public int StatusKthimLibri { get; set; }

    }
}
