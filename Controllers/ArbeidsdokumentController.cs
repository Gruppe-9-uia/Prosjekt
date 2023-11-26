using Microsoft.AspNetCore.Mvc;
using Prosjekt.Entities;
using Prosjekt.Models.Arbeidsdokument;

public class ServiceFormModel;


namespace Prosjekt.Controllers

public class ArbeidsdokumentController : Controller
{
    private readonly ProsjektContext _context;

    public ArbeidsdokumentController(ProsjektContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var serviceOrders = _context.Service_ordre.ToList();

        List<ArbeidsdokumentModelView> list = new List<ArbeidsdokumentModelView>();

        foreach (var serviceOrder in serviceOrders)
        {
            var arbeidsdokument = new ArbeidsdokumentModelView();
            
            arbeidsdokument.Orderenummer = serviceOrder.OrderID_int;
            arbeidsdokument.BeskrivelseFraKunde = serviceOrder.Description_From_Customer_str;
            arbeidsdokument.Produkttype = serviceOrder.Order_type_str;
            arbeidsdokument.Kundeinfo = serviceOrder.Order_type_str;

            
            list.Add(arbeidsdokument);
        }
        var formViewModels = _context.Service_Form.ToList();

        List<ArbeidsdokumentModelView> list = new List<ArbeidsdokumentModelView>();

        foreach (var FormView in formViewModels)
        {
            var arbeidsdokument = new ArbeidsdokumentModelView();
            
            arbeidsdokument.BooketServiceTilUke = FormView.BookedServiceWeek_int;
            arbeidsdokument.HendelseMotatt = FormView.ProductRecived_date;
            arbeidsdokument.AvtaltLevering = FormView.AgreedDelivery_date;
            arbeidsdokument.ProduktMotatt = FormView.ProductRecived_date;
            arbeidsdokument.AvtaltFerdigstillelse = FormView.AgreedDelivery_date;
            arbeidsdokument.ServiceFerdig = FormView.ServiceCompleted_date;
            arbeidsdokument.AntallTimerBrukt = FormView.Working_Hours_int;
            arbeidsdokument.ServiceSkjemaFerdig = FormView. //??;
            
            list.Add(arbeidsdokument);
        }


        ViewData["List"] = list;
        
        return View();
    }
    
}


