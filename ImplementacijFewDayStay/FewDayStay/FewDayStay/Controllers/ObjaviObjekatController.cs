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

        public IActionResult objavaObjekta(string unosNazivaObjekta, string unosBrojaKreveta, string unosKvadrature, string unosLokacijeObjekta)
        {
            Boolean validno = true;
            var objekti = baza.Objekat.Where((Objekat objekat) => objekat.Naziv.Equals(unosNazivaObjekta));
            if (objekti.Count() == 0)
            {
                //logovaniKorisnik je uvijek korisnik, prvo provjera jell vlasnik, ako jest vraca ga, ako nije brise istomenog korisnika i dodaje ga kao vlasnika
                baza.Objekat.Add(new Stan
                {
                BrojKreveta = Int32.Parse(unosBrojaKreveta),
                Kvadratura = Int32.Parse(unosKvadrature),
                Naziv = unosNazivaObjekta,
                CijenaPoNoci = 20,
                Ocjena = 5,
                Lokacija = baza.Lokacija.Where((Lokacija lokacija) => lokacija.Grad.Equals(unosLokacijeObjekta)).First(),
                Vlasnik = (Vlasnik)SignInLogInController.logovaniKorisnik,
                BrojSprata = 0,
                ImeNaUlazu = ""
                });
            baza.SaveChanges();
            }
            else validno = false;
            if(validno)
            return View("../PretragaObjekata/PretragaObjekata");
            return View("ObjavaObjekta");
        }
    }
}