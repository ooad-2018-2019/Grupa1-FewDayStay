using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Few_Day_Stay.Models
{
    public class Lokacija
{
    String drzava = "";
    String grad = "";
    int postanskiBroj = 0;
    String adresa = "";

    public Lokacija(string drzava, string grad, int postanskiBroj, string adresa)
    {
        this.Drzava = drzava;
        this.Grad = grad;
        this.PostanskiBroj = postanskiBroj;
        this.Adresa = adresa;
    }

    public string Drzava { get => drzava; set => drzava = value; }
    public string Grad { get => grad; set => grad = value; }
    public int PostanskiBroj { get => postanskiBroj; set => postanskiBroj = value; }
    public string Adresa { get => adresa; set => adresa = value; }
}
}
