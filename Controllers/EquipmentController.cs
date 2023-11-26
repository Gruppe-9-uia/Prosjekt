using Microsoft.AspNetCore.Mvc;
using Prosjekt.Entities;
using Prosjekt.Repository;
using Prosjekt.Models.Equipment;

namespace Prosjekt.Controllers
{
    [Controller]
    public class EquipmentController : Controller
    {
        private IEquipmentRepository _equipmentRepository;
        private readonly ILogger<EquipmentController> _logger;

        public EquipmentController(IEquipmentRepository equipmentRepository, ILogger<EquipmentController> logger)
        {
            _equipmentRepository = equipmentRepository;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Equipment( )
        {

            var equipmentList = _equipmentRepository.getAllEquipment();

            // Add the relevant data to view model
            List<EquimentViewModel> list = new List<EquimentViewModel>();
            foreach (var e in equipmentList)
            {
                var equipmentObj = new EquimentViewModel
                { 
                    Id = (int)e.Id_int, 
                    Availability = e.Availability, 
                    Name = e.Name_str
                };

                list.Add(equipmentObj);
            }

            //Sett the lire viewData attribute 
            ViewData["List"] = list;
           
            return View();
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddEquipment(AddEquimentModel model)
        {
            if (!ModelState.IsValid) {
                //_logger.Log("Model state was not true");
               return View();
            }

            //Check if there allerede existe equiment with that name
            if(_equipmentRepository.getEquipmentByName(model.Name_str) == null)
            {
                var EquipmentObj = new EquipmentModel
                {
                    Availability = model.Availability.Equals("true"),
                    Name_str = model.Name_str,
                };

                _equipmentRepository.InsertEquipment(EquipmentObj);
                _equipmentRepository.Save();
            }

            return RedirectToAction("Equipment");
        }

        public IActionResult DeleteEquipment(RemoveEquipmentModel model)
        {
            if (!ModelState.IsValid)
            {
                //_logger.Log("Model state was not true");
                return View();
            }

            //check if the equipment id exists if yes, then remove
            if(_equipmentRepository.getEquipmentByID(model.id) != null)
            {
                _equipmentRepository.DeleteEquipment(model.id);
                _equipmentRepository.Save();
            }

            return RedirectToAction("Equipment");
        }

    }
}
