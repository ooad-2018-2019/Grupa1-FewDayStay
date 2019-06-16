using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FewDayStay.Models
{
    public class Stan : Objekat
    {
        //U IZVEDENIM KLASAM IZ NEKE KLAS ENEMA NI FOREIGN KEY-EVA, NI PRIMARY KEY-EVA
        [Required]
        public int BrojSprata { get; set; }

        [Required]
        public string ImeNaUlazu { get; set;}

        //konstruktor,samo da bi se mogla inicijalizirati polja da se visi hoce li ih u bazi ispisati
        public Stan(int objID, int brKrev, string name, int kvadra, double cijen, double ocj, int vlID, int lokID)
        {
            //atributi iz "Objkat" klase
            this.ObjekatID = objID;
            this.BrojKreveta = brKrev;
            this.Naziv = name;
            this.Kvadratura = kvadra;
            this.CijenaPoNoci = cijen;
            this.VlasnikID = vlID;
            this.LokacijaID = lokID;

            
        }
    }
}
