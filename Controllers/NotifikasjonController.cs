using Microsoft.AspNetCore.Mvc;

namespace Prosjekt.Controllers
{
    public class NotifikasjonController : Controller
    {
        public IActionResult Notifikasjon()
        {
            return View();
        }
    }
}
