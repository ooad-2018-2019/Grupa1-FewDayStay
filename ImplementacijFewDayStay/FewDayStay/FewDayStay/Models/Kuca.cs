using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BitmapNet;

namespace FewDayStay.Models
{
    public class Kuca : Objekat
{
        [Required]
        public int BrojSpratova { get; set; }

        [Required]
        public bool ImaDvoriste { get; set; }

        [Required]
        public bool ImaBazen { get; set; }

        //konstruktor,samo da bi se mogla inicijalizirati polja da se visi hoce li ih u bazi ispisati
        /*public Kuca(int objID, int brKrev, string name, int kvadra, double cijen, double ocj, int vlID, int lokID)
        {
            this.ObjekatID = objID;
            this.BrojKreveta = brKrev;
            this.Naziv = name;
            this.Kvadratura = kvadra;
            this.CijenaPoNoci = cijen;
            this.VlasnikID = vlID;
            this.LokacijaID = lokID;
        }*/
    }
}
