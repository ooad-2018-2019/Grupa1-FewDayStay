using Few_Day_Stay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Few_Day_Stay
{
    public class Korisnik
{
    String id = "";
    String naziv = "";
    String email = "";
    String sifra = "";
    String brojTelefona;
    double racun = 0;
    Lokacija lokacija;

    public Korisnik(string id, string naziv, string email, string sifra, string brojTelefona, double racun, Lokacija lokacija)
    {
        this.Id = id;
        this.Naziv = naziv;
        this.Email = email;
        this.Sifra = sifra;
        this.BrojTelefona = brojTelefona;
        this.Racun = racun;
        this.Lokacija = lokacija;
    }

    public string Id { get => id; set => id = value; }
    public string Naziv { get => naziv; set => naziv = value; }
    public string Email { get => email; set => email = value; }
    public string Sifra { get => sifra; set => sifra = value; }
    public string BrojTelefona { get => brojTelefona; set => brojTelefona = value; }
    public double Racun { get => racun; set => racun = value; }
    public Lokacija Lokacija { get => lokacija; set => lokacija = value; }

}
}
