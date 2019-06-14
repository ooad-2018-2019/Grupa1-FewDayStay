using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FewDayStay.Models
{
    public class Iznajmljivanje
    {
        [ScaffoldColumn(false)]
        public int IznajmljivanjeID { get; set; }
        [Required]
        public int KorisnikID { get; set; }

        [Required]
        public int ObjekatID { get; set; }

        [Required]
        public DateTime PocetniDatum { get; set; }

        [Required]
        public DateTime KrajnjiDatum { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual Objekat Objekat { get; set; }
    }
}
