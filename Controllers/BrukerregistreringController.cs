﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Prosjekt.Controllers
{
    public class BrukerregistreringController : Controller
    {
        // GET: /<controller>/
        public IActionResult Brukerregistrering()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistreingFrom()
        {
            return View("Brukerregistrering");
        }
    }
}

