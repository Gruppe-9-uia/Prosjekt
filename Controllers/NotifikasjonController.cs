using Microsoft.AspNetCore.Mvc;
using Prosjekt.Models;

namespace Prosjekt.Controllers
{
    public class NotifikasjonController : Controller
    {
        private List<Notifikasjon> TestNotifikasjoner()
        {
            return new List<Notifikasjon>
            {
                new Notifikasjon { Melding = "Ny serviceordre er registrert", Status = "Fullført", Avdeling = "Servicebehandler"},
                new Notifikasjon { Melding = "Sett inn flere utstyr", Status = "Pågår", Avdeling = "Elektro"}
            };
        }

        public IActionResult Notifikasjon()
        {
            var notifikasjoner = TestNotifikasjoner();
            return View(notifikasjoner);
        }

        [HttpPost]
        public IActionResult LeggTilNotifikasjon(Notifikasjon nyNotifikasjon)
        {
            //

            var notifikasjoner = TestNotifikasjoner();
            notifikasjoner.Add(nyNotifikasjon); 

            return View("Notifikasjon", notifikasjoner);
        }
    }
}