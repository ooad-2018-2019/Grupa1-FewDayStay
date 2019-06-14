using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FewDayStay.Models
{
    //PRIMARNI KLJUC MORA BITI "imeklaseID", ISTO I ZA FOREIGN KEYEVE
    public class Korisnik
    {
        //NADKLASA IMA PRIMARY KEY I FOREIGN KEY TABELE (I AKO IMA NEKE DODATNE ATRIBUTE)

        public int korisnikID { get; set;}
        public string Naziv { get; set;}
        public string Email { get; set;}
        public string Sifra { get; set;}
        public string BrojTelefona { get; set;}
        public double Racun { get; set;}

        //za foreign key-eve mora biti ovako FORMAT!!!!!!!!!!!!!!!
        public int LokacijaID { get; set;}
        public virtual Lokacija Lokacija { get; set;}
    }
}
