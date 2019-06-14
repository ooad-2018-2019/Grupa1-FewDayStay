using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BitmapNet;

namespace FewDayStay.Models
{
    public class Kuca : Objekat
{
        public int BrojSpratova { get; set; }
        public bool ImaDvoriste { get; set; }
        public bool ImaBazen { get; set; }
    }
}
