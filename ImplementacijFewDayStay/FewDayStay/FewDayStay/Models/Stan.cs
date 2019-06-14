using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Few_Day_Stay.Models
{
    public class Stan : Objekat
{
        int brojSprata;
        string imeNaUlazu;

        public int BrojSprata { get => brojSprata; set => brojSprata = value; }
        public string ImeNaUlazu { get => imeNaUlazu; set => imeNaUlazu = value; }
    }
}
