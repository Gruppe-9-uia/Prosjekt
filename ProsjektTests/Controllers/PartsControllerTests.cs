using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using Moq;
using NSubstitute;
using Prosjekt.Controllers;
using Prosjekt.Entities;
using Prosjekt.Models.Equipment;
using Prosjekt.Models.Parts;
using Prosjekt.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosjekt.Controllers.Tests
{
    [TestClass()]
    public class PartsControllerTests
    {
        private IPartsRepository partsRepository;
        private IEquipmentRepository equipmentRepository;
        private ILogger<EquipmentController> _logger;

        public void InitializeFakes()
        {
            equipmentRepository = Substitute.For<IEquipmentRepository>();
            equipmentRepository.getAllEquipment().Returns(new List<EquipmentModel> {
                new EquipmentModel { Id_int = 1, Availability = true, Name_str = "Hammer" }});
            partsRepository = Substitute.For<IPartsRepository>();
            partsRepository.getAllParts().Returns(new List<PartsModel> {
                new PartsModel { PartID_int = 1, Quantity_available_int = 5, PartName_str = "Vinsje tau", EquipmentID_int = 1},
                new PartsModel { PartID_int = 2,  Quantity_available_int= 2, PartName_str= "Vindje del", EquipmentID_int = null}});
        }


        [TestMethod()]
        public PartsController GetUnitUnderTest()
        {
            InitializeFakes();
            return new PartsController(partsRepository, equipmentRepository, _logger);
        }

        [TestMethod()]
        public void PartsTest()
        {
            var unitUnderTest = GetUnitUnderTest();
            PartsController PartsController = new PartsController(partsRepository, equipmentRepository, _logger);

            // Add the relevant data to view model
            var result = PartsController.Parts() as ViewResult;
            List<EquimentViewModel> EquipmentList = new List<EquimentViewModel>();
            EquipmentList.Add(new EquimentViewModel { Id = 1, Availability = true, Name = "Hammer" });

            Assert.IsNotNull(result, "Result burde å være ViewRuelst");
            Assert.IsNotNull(result.ViewData["Equipment"], "Equipment data burde ikke være null");

            var actualListEquipment = (List<EquimentViewModel>)result.ViewData["Equipment"];
            for (var i = 0; i < actualListEquipment.Count; i++)
            {
                Console.WriteLine(actualListEquipment[i].Name);
                Assert.AreEqual(EquipmentList[i].Id, actualListEquipment[i].Id);
                Assert.AreEqual(EquipmentList[i].Name, actualListEquipment[i].Name);
                Assert.AreEqual(EquipmentList[i].Availability, actualListEquipment[i].Availability);

            }


            List<PartsViewModel> list = new List<PartsViewModel>();
            list.Add(new PartsViewModel { PartID_int = 1, Quantity_available_int = 5, PartName_str = "Vinsje tau", EquipmentName = "Vinsje tau" });
            list.Add(new PartsViewModel { PartID_int = 2, Quantity_available_int = 2, PartName_str = "Vindje del", EquipmentName = null });
            Assert.IsNotNull(result.ViewData["List"], "Parts data burde ikke være null");


            var actualListparts = (List<PartsViewModel>)result.ViewData["List"];
            for (var i = 0; i < actualListEquipment.Count; i++)
            {
                Assert.AreEqual(list[i].PartID_int, list[i].PartID_int);
                Assert.AreEqual(list[i].PartName_str, list[i].PartName_str);
                Assert.AreEqual(list[i].Quantity_available_int, list[i].Quantity_available_int);
                Assert.AreEqual(list[i].EquipmentName, list[i].EquipmentName);
            }
        }

        [TestMethod()]
        public void UpdateQuantityTest()
        {
            AddPartTest();
            var mockService = new Mock<IPartsRepository>();
            var mockEquiment = new Mock<IEquipmentRepository>();
            var controller = new PartsController(mockService.Object, mockEquiment.Object, _logger);

            var result = controller.UpdateQuantity(1, 5);
            mockService.Verify(x => x.UpdateParts(It.IsAny<PartsModel>()), Times.Once);

        }

        [TestMethod()]
        public void AddPartTest()
        {

            EquipmentControllerTests eq = new EquipmentControllerTests();
            eq.AddEquipmentTest();

            InitializeFakes();
            var mockService = new Mock<IPartsRepository>();
            var mockEquiment = new Mock<IEquipmentRepository>();
            var controller = new PartsController(mockService.Object, mockEquiment.Object, _logger);

            var partsObj = new AddPartsModel {Quantity_available_int = 5, PartName_str = "Vinsje tau", EquipmentName = "Hammer" };

            var result = controller.AddPart(partsObj);
            mockService.Verify(x => x.InsertParts(It.IsAny<PartsModel>()), Times.Once);
        }

        [TestMethod()]
        public void DeletePartTest()
        {

            AddPartTest();

            var mockService = new Mock<IPartsRepository>();
            var mockEquiment = new Mock<IEquipmentRepository>();
            var controller = new PartsController(mockService.Object, mockEquiment.Object, _logger);

            var result = controller.DeletePart(1);
            mockService.Verify(x => x.DeleteParts(It.Is<int>(x => 1 == x)), Times.Once);
        }
    }
}