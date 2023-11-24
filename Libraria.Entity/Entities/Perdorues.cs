using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Libraria.Entity.Entities
{
    public class Perdorues : IdentityUser
    {
        [Required]
        public string Emri { get; set; }
        [Required]
        public string Mbiemri { get; set; }

        public bool? Statusi { get; set; }
        public DateTime DataRegj { get; set; }
        public string FotoProfiliURl { get; set; }
        public string Foto { get; set; }


        public Perdorues()
        {
            Statusi = true;
            this.DataRegj = DateTime.Now;
        }
    }
}
