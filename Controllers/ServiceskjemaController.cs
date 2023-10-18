using Microsoft.AspNetCore.Mvc;

namespace Prosjekt.Controllers
{
    public class ServiceskjemaController : Controller
    {
        public IActionResult Serviceskjema()
        {
            return View();
        }
    }
}
