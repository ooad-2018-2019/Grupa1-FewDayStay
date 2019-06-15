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
    }

    //aaaaaaaaaaaaaaaaaaaaaaaaa
}
