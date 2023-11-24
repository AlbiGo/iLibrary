using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Libraria.Entity.Entities
{
    public class KerkesePrind
    {

        [Required]
        [Key]
        public Guid Id { get; set; }
        public int NmrLibrave { get; set; }

        public Guid? KerkuesId { get; set; }
        public bool? Status { get; set; } //1 => Aprovuar 
        public string EmerLexuesi { get; set; }
        public string MbiemerLexuesi { get; set; }
        public DateTime? DitelindjaLexuesit { get; set; }

        public DateTime? DataKerkese { get; set; }
        public DateTime? DataAprovimit { get; set; }
        public DateTime? DataRefuzimit { get; set; }
        public DateTime? DataMarrjes { get; set; }
        public DateTime? DataKthimit { get; set; }
        public DateTime? DataTerheqjes { get; set; }
    }
}
