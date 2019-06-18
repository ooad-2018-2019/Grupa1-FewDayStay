using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FewDayStay.Models;
using Microsoft.AspNetCore.Mvc;

namespace FewDayStay.Controllers
{
    public class SignInLogInController : Controller
    {
        private static DBContext database = DBContext.dajInstancu();
        public static Osoba logovaniKorisnik = null;
        public IActionResult SignInLogIn()
        {
            return View("SignInLogIn");
        }
        [HttpPost]
        public IActionResult ValidateSignIn(string unosImena, string unosPrezimena, string unosEmaila, string unosSifre, string unosDatumaRodjenja)
        {
            Boolean validno = true;
            if (unosImena.Equals("") || unosPrezimena.Equals("") || unosSifre.Equals("") || unosDatumaRodjenja.Equals("") || unosEmaila.Equals("")) validno = false;

            var korisnici = database.Osoba.Where((Osoba osoba) => osoba.Naziv.Equals(unosImena + " " + unosPrezimena) && osoba.Sifra.Equals(unosSifre));
            if (korisnici.Count() == 0)
            {
                database.Osoba.Add(new Korisnik
                {
                    Naziv = unosImena + " " + unosPrezimena,
                    Email = unosEmaila,
                    Sifra = unosSifre,
                    BrojTelefona = "",
                    Racun = 0,
                    Lokacija = database.Lokacija.First()

                });
                database.SaveChanges();
            }
            else validno = false;
           
            if (validno)
            {
                dajLogovanogKorisnika(unosImena, unosSifre);
                return View("../PretragaObjekata/PretragaObjekata");
            }
            //vraca ga opet na formu da se loginuje ako postoji
            return View("SignInLogIn");
        }
        [HttpPost]
        public IActionResult ValidateLogIn(string loginIme, string loginSifra)
        {
            Boolean validno = true;
            if (loginIme.Equals("") || loginSifra.Equals("")) validno = false;
            var korisnici = database.Osoba.Where((Osoba osoba) => osoba.Sifra.Equals(loginSifra) && osoba.Naziv.Contains(loginIme));
            if (korisnici.Count() == 0)
                validno = false;
            if (validno)
            {
                dajLogovanogKorisnika(loginIme, loginSifra);
                return View("../PretragaObjekata/PretragaObjekata");
            }
            //vraca ga na istu formu da se signin
            return View("SignInLogIn");

        }
        private static void dajLogovanogKorisnika(string imeKorisnika, string sifraKorisnika)
        {
            //logovaniKorisnik = database.dajKorisnika(imeKorisnika, sifraKorisnika);
            //database.dajKorisnika(imeKorisnika, sifraKorisnika); vraca instancu Vlasnika ili Korisnika
            var data = database.Osoba.Where((Osoba osoba) => osoba.Naziv.Contains(imeKorisnika) && osoba.Sifra.Equals(sifraKorisnika));
            if (data.Count() != 0)
            logovaniKorisnik = data.First();
        }
    }
}
    