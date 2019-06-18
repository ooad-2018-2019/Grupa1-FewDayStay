using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FewDayStay.Models;
using Microsoft.AspNetCore.Mvc;

namespace FewDayStay.Controllers
{
    public class PretragaObjekataController : Controller
    {
        public IActionResult PretragaObjekata()
        {
            return View("PretragaObjekata");
        }
        public IActionResult filtriranje(string filterPoImenuApartmana, string filterPoCijeni, string filterPoLokaciji, string filterPoImenuVlasnika)
        {
            DBContext baza = DBContext.dajInstancu();
            List<Objekat> objekti = baza.Objekat.ToList();
            if (filterPoImenuApartmana!=null)
            {
                System.Diagnostics.Debug.WriteLine(filterPoImenuApartmana);
                objekti = baza.Objekat.Where((Objekat o) => o.Naziv.Equals(filterPoImenuApartmana)).ToList();
            }
            if (filterPoCijeni != null)
            {
                objekti = baza.Objekat.Where((Objekat o) => o.CijenaPoNoci.Equals(double.Parse(filterPoCijeni))).ToList();
            }
            if (filterPoLokaciji != null)
            {
                Lokacija idLokacije = baza.Lokacija.Where((Lokacija l) => l.Grad.Equals(filterPoLokaciji)).First();
                objekti = baza.Objekat.Where((Objekat o) => o.LokacijaID.Equals(idLokacije.LokacijaID)).ToList();
            }
            if (filterPoImenuVlasnika != null)
            {
                Osoba imeVlasnika = baza.Osoba.Where((Osoba os) => os.Naziv.Contains(filterPoImenuVlasnika)).First();
                objekti = baza.Objekat.Where((Objekat o) => o.VlasnikID.Equals(imeVlasnika.OsobaID)).ToList();
            }
            return View("PretragaObjekata", objekti);
        }
    }
}
