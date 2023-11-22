using Microsoft.AspNetCore.Mvc;

namespace Prosjekt.Controllers
{
    public class OversiktController : Controller
    {
        public IActionResult Oversikt()
        {
            return View();
        }
    }
}
