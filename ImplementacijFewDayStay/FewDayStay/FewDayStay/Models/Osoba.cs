using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FewDayStay.Models
{
    public abstract class Osoba
    {
        //BUKVALNO IME KLASE + ID!!!!!!!!!!!!!!!!!!!!
        [ScaffoldColumn(false)]
        public int OsobaID { get; set; }

        [Required]
        public string Naziv { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Sifra { get; set; }

        [Required]
        public string BrojTelefona { get; set; }

        [Required]
        public double Racun { get; set; }

        //za foreign key-eve mora biti ovakav FORMAT!!!!!!!!!!!!!!!
        public int LokacijaID { get; set; }
        public virtual Lokacija Lokacija { get; set; }
    }
}
