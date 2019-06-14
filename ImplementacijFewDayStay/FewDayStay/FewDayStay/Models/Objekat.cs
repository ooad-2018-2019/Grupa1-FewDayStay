using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BitmapNet;

namespace FewDayStay.Models
{
    public class Objekat
{
        int brojKreveta;
        string naziv;
        int kvadratura;
        Lokacija lokacija;
        double cijenaPoNoci;
        double ocjena;
        List<Bitmap> slike;
        public int BrojKreveta { get => brojKreveta; set => brojKreveta = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public int Kvadratura { get => kvadratura; set => kvadratura = value; }
        public double CijenaPoNoci { get => cijenaPoNoci; set => cijenaPoNoci = value; }
        public double Ocjena { get => ocjena; set => ocjena = value; }
        public Lokacija Lokacija { get => lokacija; set => lokacija = value; }

        public void ocijeni(double ocjena)
        {
        }
}
}
