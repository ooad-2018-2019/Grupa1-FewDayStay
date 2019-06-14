using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FewDayStay.Models
{
    public class Stan : Objekat
    {
        //U IZVEDENIM KLASAM IZ NEKE KLAS ENEMA NI FOREIGN KEY-EVA, NI PRIMARY KEY-EVA

        public int BrojSprata { get; set; }
        public string ImeNaUlazu { get; set;}
    }
}
