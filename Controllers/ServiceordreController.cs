using Microsoft.AspNetCore.Mvc;
using Prosjekt.Models.ServiceOrdre;

namespace Prosjekt.Controllers
{
    public class ServiceordreController : Controller
    {
        public IActionResult Serviceordre()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(ServiceOrdreModel model)
        {
            if (ModelState.IsValid)
            {
                var s = "ineedabreakpoint";

            }
            return View("Serviceordre", model);
        }
    }
}

