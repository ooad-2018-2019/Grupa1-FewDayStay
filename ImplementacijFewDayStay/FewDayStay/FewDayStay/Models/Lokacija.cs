using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FewDayStay.Models
{
    public class Lokacija
    {
        [ScaffoldColumn(false)]
        public int LokacijaID { get; set; }

        [Required]
        public string Drzava { get; set;}

        [Required]
        public string Grad { get; set; }

        [Required]
        public int PostanskiBroj { get; set; }

        [Required]
        public string Adresa { get; set;}
    }
}
