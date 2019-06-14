using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FewDayStay.Models
{
    public class Osoba
    {
        //BUKVALNO IME KLASE + ID!!!!!!!!!!!!!!!!!!!!
        public int OsobaID { get; set; }
        public string Naziv { get; set; }
        public string Email { get; set; }
        public string Sifra { get; set; }
        public string BrojTelefona { get; set; }
        public double Racun { get; set; }

        //za foreign key-eve mora biti ovakav FORMAT!!!!!!!!!!!!!!!
        public int LokacijaID { get; set; }
        public virtual Lokacija Lokacija { get; set; }
    }
}
