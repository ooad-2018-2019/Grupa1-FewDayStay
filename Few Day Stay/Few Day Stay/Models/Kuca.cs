using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BitmapNet;

namespace Few_Day_Stay.Models
{
    public class Kuca : Objekat
{
        int brojSpratova;
        bool imaDvoriste;
        bool imaBazen;
        public int BrojSpratova { get => brojSpratova; set => brojSpratova = value; }
        public bool ImaDvoriste { get => imaDvoriste; set => imaDvoriste = value; }
        public bool ImaBazen { get => imaBazen; set => imaBazen = value; }
    }
}
