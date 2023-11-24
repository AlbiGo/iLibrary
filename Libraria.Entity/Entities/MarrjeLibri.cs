﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Libraria.Entity.Entities
{
    public class MarrjeLibri
    {
        [Required]
        [System.ComponentModel.DataAnnotations.Key]
        public Guid ID { get; set; }
        [ForeignKey("Lexuesit")]
        public Guid LexuesId { get; set; }
        [ForeignKey("Librat")]
        public Guid LiberId { get; set; }
        [ForeignKey("Perdoruesit")]
        public Guid? Aprovuesi { get; set; }
        [ForeignKey("TipiLeshimLibri")]
        public int TipiLeshimit { get; set; }
        [ForeignKey("Kerkesat")]
        public Guid? KerkeseId { get; set; }
        public DateTime AfatiKthimit { get; set; }
        public DateTime DataMarrjes { get; set; }
        public DateTime DataKthimit { get; set; }
        public bool? Status { get; set; } // Marre => Aktiv , Kthyer => Joaktiv

        public MarrjeLibri()
        {
            DataMarrjes = DateTime.Now;
            AfatiKthimit = DateTime.Now.AddDays(30);
        }
        public virtual Perdorues Aprovues { get; set; }
        public virtual Lexues Lexues { get; set; }
        public virtual Liber Liber { get; set; }
    }
}
