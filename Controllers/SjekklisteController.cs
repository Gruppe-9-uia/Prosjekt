using Microsoft.AspNetCore.Mvc;
using Prosjekt.Models;

//TODO: prøve å fikse som modelstate sjekke kan kjøre

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
            //For teste formål, blir fjerne når databasen blir lagt til
            Sjekkliste.Document_nr_str = "IG-IN-104-01-01";
            Sjekkliste.Starting_Date = new DateOnly(2023, 10, 24);
            Sjekkliste.Serial_number_str = "77777-test";
            Sjekkliste.Prepared_by_str = "JBS";
            Sjekkliste.Procedure_str = "Servicesjekkliste vinsjer";

            //Funskjonalt er avhengig av database for å sende den inn som blir lagret
            // Vil ikke kjøre det sinde er mest sannsynlig null verdier i modellen, 
            //if (!ModelState.IsValid) { return View();
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
            }
            catch (Exception ex)
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

        [HttpPost]
        public IActionResult SignForm(SjekklisteModel Sjekkliste)
        {
            //Funskjonalt er avhengig av database for å sende den inn som blir lagret
            if (!ModelState.IsValid) return View();

            return RedirectToAction("Sjekklist");

        }
    }
}