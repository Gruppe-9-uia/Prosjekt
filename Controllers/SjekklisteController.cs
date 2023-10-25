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
        public IActionResult GenerrellForm(SjekklisteModel Sjekkliste)
        {
            //Funskjonalt er avhengig av database for å sende den inn som blir lagret
            if (!ModelState.IsValid) return View();
            try
            {
                var Type_str = Sjekkliste.Type_str;
                var xx_Bar_str = Sjekkliste.xx_Bar_str;
                var Test_winch = Sjekkliste.Test_winch;
                var Brake_force = Sjekkliste.Brake_force;
                var Traction_force_Kn = Sjekkliste.Traction_force_Kn;
                var comment_str = Sjekkliste.comment_str;

                //test om får hentet data, skal fjernes
                Console.WriteLine(Type_str);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return RedirectToAction("Sjekklist");
        }
        [HttpPost]
        public IActionResult MekaniskForm(SjekklisteModel Sjekkliste)
        {
            //Funskjonalt er avhengig av database for å sende den inn som blir lagret
            if (!ModelState.IsValid) return View();

            return RedirectToAction("Sjekklist");

        }
        [HttpPost]
        public IActionResult HydrauliskForm(SjekklisteModel Sjekkliste)
        {
            //Funskjonalt er avhengig av database for å sende den inn som blir lagret
            if (!ModelState.IsValid) return View();

            return RedirectToAction("Sjekklist");

        }
        [HttpPost]
        public IActionResult ElektroForm(SjekklisteModel Sjekkliste)
        {
            //Funskjonalt er avhengig av database for å sende den inn som blir lagret
            if (!ModelState.IsValid) return View();

            return RedirectToAction("Sjekklist");

        }
    }
}
