using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FewDayStay.Models
{
    public class Lokacija
    {
        public int LokacijaID { get; set; }
        public string Drzava { get; set;}
        public string Grad { get; set; }
        public int PostanskiBroj { get; set; }
        public string Adresa { get; set;}
    }
}
