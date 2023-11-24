using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Libraria.Entity.Entities
{
    public class Lexues
    {
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string NmrId { get; set; }
        [Required]
        public string Emri { get; set; }
        [Required]
        public string Mbiemri { get; set; }

        public bool? Statusi { get; set; }
        public DateTime DataRegj { get; set; }
        public string FotoProfiliURl { get; set; }
        public string KarteLeximiURL { get; set; }
        public DateTime? Datelindja { get; set; }
        public string Adresa { get; set; }
        public string Qyteti { get; set; }
        public string KodiPostar { get; set; }
        public string Email { get; set; }
        public string Vendlindja { get; set; }
        public string BardCode { get; set; }


        public string Universiteti { get; set; }
        public string Atesia { get; set; }
        public string Memesia { get; set; }

        public string NumriId { get; set; }

        public DateTime? DataSkadimitTeKartes { get; set; }

        public string Karta { get; set; }
        public string Foto { get; set; }


        public Lexues()
        {
            Statusi = true;
            this.Datelindja = DateTime.Now;//Testing Purpose
            this.DataRegj = DateTime.Now;
            this.DataSkadimitTeKartes = DateTime.Now.AddDays(730);
        }
    }
}

