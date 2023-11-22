using Microsoft.AspNetCore.Mvc;
using Prosjekt.Entities;
using Prosjekt.Models.Checklist;

//TODO: prøve å fikse som modelstate sjekke kan kjøre

namespace Prosjekt.Controllers
{
    public class SjekklisteController : Controller
    {
        private readonly ProsjektContext _context;
        public SjekklisteController(ProsjektContext _context) {
            this._context = _context;
        }  

        public IActionResult Sjekkliste()
        {
            //TODO: må ha en side for å danne informasjon for dette

            try
            {
               
                return View();
            } catch (Exception ex)
            {
                return View("Error");
            }
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(ChecklistViewModel addSjekkliste)
        {
            try
            {
                var productID = _context.Product.Where(x => x.SerialNr_str.Equals(addSjekkliste.SerialNr_str)).FirstOrDefault();
                if (productID == null)
                {
                    ModelState.AddModelError(string.Empty, "Klarte ikke å lage service order");
                    return RedirectToAction("Sjekkliste");
                }

                Console.WriteLine(addSjekkliste.Bearing_drum);


                var checklistDB = new ChecklistModel();
                checklistDB.DocID_str = addSjekkliste.DocID_str;
                checklistDB.SerialNr_str = addSjekkliste.SerialNr_str;
                checklistDB.Type_str = addSjekkliste.Type_str;
                checklistDB.Procedure_str = addSjekkliste.Procedure_str;
                checklistDB.Starting_Date = addSjekkliste.Starting_Date;
                checklistDB.Prepared_by_str = addSjekkliste.Prepared_by_str;
                checklistDB.xx_Bar_str = addSjekkliste.xx_Bar_str;
                checklistDB.Brake_force = addSjekkliste.Brake_force;
                checklistDB.Traction_force_Kn = addSjekkliste.Traction_force_Kn;
                checklistDB.Test_winch = addSjekkliste.Test_winch;
                checklistDB.comment_str = addSjekkliste.comment_str;
                checklistDB.Hydraulic_cylinder = addSjekkliste.Hydraulic_cylinder;
                checklistDB.Hoses = addSjekkliste.Hoses;
                checklistDB.Hydraulic_block = addSjekkliste.Hydraulic_block;
                checklistDB.Oil_tank = addSjekkliste.Oil_tank;
                checklistDB.HOil_gearbox = addSjekkliste.HOil_gearbox;
                checklistDB.Ringe_cylinder_and_replace_seals = addSjekkliste.Ringe_cylinder_and_replace_seals;
                checklistDB.Brake_cylinder_and_replace_seals = addSjekkliste.Brake_cylinder_and_replace_seals;
                checklistDB.Clutch_Plate = addSjekkliste.Clutch_Plate;
                checklistDB.Check_Brakes = addSjekkliste.Check_Brakes;
                checklistDB.Bearing_drum = addSjekkliste.Bearing_drum;
                checklistDB.PTO_and_storage = addSjekkliste.PTO_and_storage;
                checklistDB.Chain_tensioners = addSjekkliste.Chain_tensioners;
                checklistDB.Wire = addSjekkliste.Wire;
                checklistDB.Pinion_bearing = addSjekkliste.Pinion_bearing;
                checklistDB.Wedge_on_sprocket = addSjekkliste.Wedge_on_sprocket;
                checklistDB.Wiring_on_winch = addSjekkliste.Wedge_on_sprocket;
                checklistDB.Test_radio = addSjekkliste.Test_radio;
                checklistDB.EOil_gearbox = addSjekkliste.EOil_gearbox;

                _context.Checklist.Add(checklistDB);

                _context.SaveChanges();

                // sign checkList

                var employeeID = _context.Employees.Where(e => e.FirstName_str.Equals(addSjekkliste.FirstName_str) 
                && e.LastName_str.Equals(addSjekkliste.LastName_str)).FirstOrDefault();

                if(employeeID == null )
                {
                    ModelState.AddModelError(string.Empty, "Klarte ikke å lage service order");
                    return RedirectToAction("Sjekklist");
                }
                var checkSign = new ChecklistSignatureModel();
                checkSign.Sign_Date = addSjekkliste.signDate;
                checkSign.EmployeeID_int = employeeID.Id;
                checkSign.DocID_str = addSjekkliste.DocID_str;
                _context.Checklist_signature.Add(checkSign);
                _context.SaveChanges();

                return RedirectToAction("Add");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return RedirectToAction("Sjekkliste");
        }

    }
}