using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FewDayStay.Models
{
    public class Iznajmljivanje
    {
        //ATRIBUTI
        private Korisnik korisnik;
        private Objekat objekat;
        private DateTime pocetniDatum;
        private DateTime krajnjiDatum;

        //GETTERI I SETTERI
        public Korisnik Korisnik { get => korisnik; set => korisnik = value; }
        public Objekat Objekat { get => objekat; set => objekat = value; }
        public DateTime PocetniDatum { get => pocetniDatum; set => pocetniDatum = value; }
        public DateTime KrajnjiDatum { get => krajnjiDatum; set => krajnjiDatum = value; }

        //KONSTRUKTOR
        public Iznajmljivanje(Korisnik korisnik, Objekat objekat, DateTime pocetniDatum, DateTime krajnjiDatum)
        {
            this.korisnik = korisnik;
            this.objekat = objekat;
            this.pocetniDatum = pocetniDatum;
            this.krajnjiDatum = krajnjiDatum;
        }

        //METODE

    }
}
