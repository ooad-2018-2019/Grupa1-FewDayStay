using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BitmapNet;

namespace FewDayStay.Models
{
    public class Objekat
{
        public int ObjekatID { get; set; }
        public int BrojKreveta { get; set; }
        public string Naziv { get; set; }
        public int Kvadratura { get; set; }
        public double CijenaPoNoci { get; set; }
        public double Ocjena { get; set; }

        //preko diskriminatora u tabeli, iako ne psotoji kolona "VlaskinID" ce biti generisano da radi
        public int VlasnikID { get; set; }
        public int LokacijaID { get; set; }

        public virtual Lokacija Lokacija { get; set; }
        public virtual Vlasnik Vlasnik { get; set;}
    }
}
