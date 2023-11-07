using Microsoft.AspNetCore.Mvc;
using Prosjekt.Models;

//TODO: prøve å fikse som modelstate sjekke kan kjøre

namespace Prosjekt.Controllers
{
    public class SjekklistController : Controller
    {
        private readonly ProsjektContext _context;
        public SjekklistController(ProsjektContext _context) {
            this._context = _context;
        }  

        public IActionResult Sjekklist()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GenerrellForm(SjekklisteModel addSjekkliste)
        {
            //For teste formål, blir fjerne når databasen blir lagt til

            //Funskjonalt er avhengig av database for å sende den inn som blir lagret
            // Vil ikke kjøre det sinde er mest sannsynlig null verdier i modellen, 
            //if (!ModelState.IsValid) { return View();
            try
            {
                var sjekkliste = new SjekklisteModel()
                {
                    DocID_str = addSjekkliste.DocID_str,
                    SerialNr_str = addSjekkliste.SerialNr_str
                };
                _context.Sjekkliste.AddAsync(sjekkliste);
                _context.SaveChangesAsync(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return RedirectToAction("addSjekkliste");
        }

    }
}