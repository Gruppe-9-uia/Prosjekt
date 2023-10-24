using Microsoft.AspNetCore.Mvc;
using Prosjekt.Models;

namespace Prosjekt.Controllers
{
    public class SjekklistController : Controller
    {

        public IActionResult Sjekklist()
        {
            return View();
        }

        [HttpPost]
        public IActionResult generelForm(SjekklisteModel Sjekkliste)
        {
            //Funskjonalt er avhengig av database for å sende den inn som blir lagret
            if (!ModelState.IsValid) return View();

            return View();
        }

        public IActionResult MekaniskForm(SjekklisteModel Sjekkliste)
        {
            //Funskjonalt er avhengig av database for å sende den inn som blir lagret
            if (!ModelState.IsValid) return View();

            return View();
        }

        public IActionResult HydrauliskForm(SjekklisteModel Sjekkliste)
        {
            //Funskjonalt er avhengig av database for å sende den inn som blir lagret
            if (!ModelState.IsValid) return View();

            return View();
        }

        public IActionResult ElektroForm(SjekklisteModel Sjekkliste)
        {
            //Funskjonalt er avhengig av database for å sende den inn som blir lagret
            if (!ModelState.IsValid) return View();

            return View();
        }
    }
}
