using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FewDayStay.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignIn(string inputEmail,string inputPassword)
        {
            //Provjera da li postoji user sa inputEmail i inputPAssword vrijednostima
            return View("../User/Pocetna");
        }
    }
}