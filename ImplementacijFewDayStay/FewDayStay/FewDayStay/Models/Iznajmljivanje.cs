using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FewDayStay.Models
{
    public class Iznajmljivanje
    {
        public int IznajmljivanjeID { get; set; }
        public int KorisnikID { get; set; }
        public int ObjekatID { get; set; }
        public DateTime PocetniDatum { get; set; }
        public DateTime KrajnjiDatum { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual Objekat Objekat { get; set; }
    }
}
