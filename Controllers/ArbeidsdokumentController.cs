using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prosjekt.Entities;
using Prosjekt.Models;
using System.Linq;

namespace Prosjekt.Controllers
{
    public class ArbeidsdokumentController : Controller
    {
        private readonly ProsjektContext _context;

        public ArbeidsdokumentController(ProsjektContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            /*
            var arbeidsdokumentModelViews = _context.Service_Form
                .Include(sf => sf.Customer)
                .Include(sf => sf.ServiceOrder)
                .Include(sf => sf.ServiceOrder.CustomerProduct)
                .Include(sf => sf.ServiceFormEmployee)
                .Include(sf => sf.ServiceFormSign)
                .Select(sf => new ArbeidsdokumentModelView
                {
                    BooketServiceTilUke = sf.BookedServiceWeek_int.ToString(),
                    HendelseMotatt = sf.Received_Date,
                    Orderenummer = sf.FormID_int,
                    Produkttype = sf.Service_Order.Order_type_str,
                    BeskrivelseFraKunde = sf.Service_Order.Description_From_Customer_str,
                    Kundeinfo = sf.Customer.FirstName_str + " " + sf.Customer.LastName_str,
                    AvtaltLevering = sf.AgreedDelivery_date,
                    ProduktMotatt = sf.ProductRecived_date,
                    AvtaltFerdigstillelse = sf.AgreedDelivery_date,
                    ServiceFerdig = sf.ServiceCompleted_date,
                    AntallTimerBrukt = sf.AntallTimerBrukt,
                    ServiceSkjemaFerdig = sf.ServiceSkjemaFerdig
                })
                .ToList();
            */
            return View("Arbeidsdokument");
        }
    }
}