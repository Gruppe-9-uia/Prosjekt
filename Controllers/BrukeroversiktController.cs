using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Prosjekt.Controllers
{
    public class BrukeroversiktController : Controller
    {
        // GET: /<controller>/
        public IActionResult Brukeroversikt()
        {
            return View();
        }

        public IActionResult BackBrukeroversikt()
        {
            return RedirectToAction("Brukeroversikt");
        }
    }
}
