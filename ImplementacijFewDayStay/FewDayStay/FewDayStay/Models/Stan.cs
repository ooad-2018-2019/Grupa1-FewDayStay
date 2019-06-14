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
    }
}
