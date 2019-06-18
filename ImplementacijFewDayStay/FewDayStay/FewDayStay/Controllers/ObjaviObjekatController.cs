using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FewDayStay.Models;
using Microsoft.AspNetCore.Mvc;

namespace FewDayStay.Controllers
{
    public class ObjaviObjekatController : Controller
    {
        DBContext baza = DBContext.dajInstancu();
        public IActionResult ObjaviObjekat()
        {
            return View();
        }

        public IActionResult objavaObjekta(string unosNazivaObjekta, string unosBrojaKreveta, string unosKvadrature, string unosLokacijeObjekta, string unosCijenePoNoci, string radioDugme)
        {
            Boolean validno = true;
            if (SignInLogInController.logovaniKorisnik == null) return View("ObjaviObjekat");
            var objekti = baza.Objekat.Where((Objekat objekat) => objekat.Naziv.Equals(unosNazivaObjekta));
            System.Diagnostics.Debug.WriteLine(unosLokacijeObjekta);
            if (objekti.Count() == 0)
            {
                //logovaniKorisnik je uvijek korisnik, prvo provjera jell vlasnik, ako jest vraca ga, ako nije brise istomenog korisnika i dodaje ga kao vlasnika
                if(SignInLogInController.logovaniKorisnik is Korisnik)
                {
                    baza.Add(new Vlasnik
                    {
                        Naziv = SignInLogInController.logovaniKorisnik.Naziv,
                        Email = SignInLogInController.logovaniKorisnik.Email,
                        Sifra = SignInLogInController.logovaniKorisnik.Sifra,
                        BrojTelefona = "",
                        Racun = 0,
                        Lokacija = baza.Lokacija.First()
                    });
                    baza.Osoba.Remove(SignInLogInController.logovaniKorisnik);
                    baza.SaveChanges();
                    //znaci zadnji koji je dodan
                    SignInLogInController.logovaniKorisnik = baza.Osoba.Last();
                }
                if (radioDugme.Equals("Stan"))
                {
                    baza.Objekat.Add(new Stan
                    {
                        BrojKreveta = Int32.Parse(unosBrojaKreveta),
                        Kvadratura = Int32.Parse(unosKvadrature),
                        Naziv = unosNazivaObjekta,
                        CijenaPoNoci = Int32.Parse(unosCijenePoNoci),
                        Ocjena = 5,
                        Lokacija = baza.Lokacija.Where((Lokacija lokacija) => lokacija.Grad.Equals(unosLokacijeObjekta)).First(),
                        Vlasnik = (Vlasnik)SignInLogInController.logovaniKorisnik,
                        BrojSprata = 0,
                        ImeNaUlazu = ""
                    });
                    baza.SaveChanges();
                }
                else
                {
                    baza.Objekat.Add(new Kuca
                    {
                        BrojKreveta = Int32.Parse(unosBrojaKreveta),
                        Kvadratura = Int32.Parse(unosKvadrature),
                        Naziv = unosNazivaObjekta,
                        CijenaPoNoci = Int32.Parse(unosCijenePoNoci),
                        Ocjena = 5,
                        Lokacija = baza.Lokacija.Where((Lokacija lokacija) => lokacija.Grad.Equals(unosLokacijeObjekta)).First(),
                        Vlasnik = (Vlasnik)SignInLogInController.logovaniKorisnik,
                        BrojSpratova = 0,
                        ImaBazen = false,
                        ImaDvoriste = false
                    });
                    baza.SaveChanges();
                }
            }
            else validno = false;
            if(validno)
            return View("../PretragaObjekata/PretragaObjekata");
            return View("ObjaviObjekat");
        }
    }
}