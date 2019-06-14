using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BitmapNet;

namespace FewDayStay.Models
{
    public abstract class Objekat
{
        [ScaffoldColumn(false)]
        public int ObjekatID { get; set; }

        [Required]
        public int BrojKreveta { get; set; }

        [Required]
        public string Naziv { get; set; }

        [Required]
        public int Kvadratura { get; set; }

        [Required]
        public double CijenaPoNoci { get; set; }

            [Required]
            public double Ocjena { get; set; }

        //preko diskriminatora u tabeli, iako ne psotoji kolona "VlaskinID" ce biti generisano da radi
        public int VlasnikID { get; set; }
        public int LokacijaID { get; set; }

        public virtual Lokacija Lokacija { get; set; }
        public virtual Vlasnik Vlasnik { get; set;}
    }
}
