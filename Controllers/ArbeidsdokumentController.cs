using Microsoft.AspNetCore.Mvc;

namespace Prosjekt.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
