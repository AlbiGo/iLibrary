using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Libraria.Entity.Entities
{
    public class Liber
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
        [Required]
        public Guid? Kategoria { get; set; }
        [Required]
        public Guid? Statusi { get; set; }
        [Required]
        public DateTime? DataRegj { get; set; }
        public DateTime? DataPerditesimit { get; set; }
        [Required]
        public string Vendi { get; set; }
        public string FotoLibbriUrl { get; set; }
        public string FotoLibri { get; set; }
       // public int? Sasia { get; set; }

        public string IBN { get; set; }

        public virtual KategoriLibri Kategori { get; set; }
        public virtual StatusLibri Status { get; set; }

        public Liber()
        {
            DataRegj = DateTime.Now;
            this.DataPerditesimit = DateTime.Now;
            Statusi = new Guid("4128E73C-D0AC-4D44-98E9-A3467CC3E7AD");
        }


    }
}
