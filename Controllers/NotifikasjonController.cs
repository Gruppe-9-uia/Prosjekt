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
                new Notifikasjon
                    { Melding = "Serviceform er fullført", Status = "Fullført", Avdeling = "Hydreulisk" },
                new Notifikasjon { Melding = "Serviceform er i gang", Status = "Pågår", Avdeling = "Elektro" }
            };
        }

        public IActionResult Notifikasjon()
        {
            var notifikasjoner = TestNotifikasjoner();
            return View(notifikasjoner);
        }
    }
}