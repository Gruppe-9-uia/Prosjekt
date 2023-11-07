using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Save(ServiceOrderModel model)
        {
            if (ModelState.IsValid)
            {
                var s = "ineedabreakpoint";

            }
            return View("Serviceordre", model);
        }
    }
}

