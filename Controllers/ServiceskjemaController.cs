using Microsoft.AspNetCore.Mvc;
using Prosjekt.Entities;

namespace Prosjekt.Controllers
{
    public class ServiceSkjemaController : Controller
    {
        public IActionResult ServiceSkjema()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(ServiceFormModel model)
        {
            if (ModelState.IsValid)
            {
                var s = "ineedabreakpoint";

            }
            return View("Serviceskjema", model);
        }
    }
}