using Microsoft.AspNetCore.Mvc;
using Prosjekt.Models;

public class AccountController : Controller
{
    private AppDbContext db = new AppDbContext();

    public ActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Register(User user)
    {
        if (ModelState.IsValid)
        {
            // i virkeligheten ville hashet og saltet dette passordet.
            db.Users.Add(user);
            db.SaveChanges();
            return RedirectToAction("Login");
        }
        return View(user);
    }

    public ActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Login(User user)
    {
        var registeredUser = db.Users.FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password);
        if (registeredUser != null)
        {
            // Brukeren er innlogget. Implementer en innlogging/logg ut mekanisme.
            return RedirectToAction("Index", "Home");
        }

        ModelState.AddModelError("", "Feil brukernavn eller passord.");
        return View(user);
    }
}

