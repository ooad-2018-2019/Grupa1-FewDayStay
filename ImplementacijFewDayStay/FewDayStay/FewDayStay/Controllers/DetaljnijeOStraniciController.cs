using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FewDayStay.Controllers
{
    public class DetaljnijeOStraniciController : Controller
    {
        public IActionResult DetaljnijeOStranici()
        {
            return View();
        }
    }
}