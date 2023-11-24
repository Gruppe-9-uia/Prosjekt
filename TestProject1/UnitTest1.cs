using Prosjekt;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Prosjekt.Controllers;
using Prosjekt.Entities;
using Prosjekt.Models.Parts;

namespace Prosjekt.TestProsjekt1.Controllers
{
    [TestFixture]
    public class PartsControllerTests
    {
        private ProsjektContext _context;

        [SetUp]
        public void Setup()
        {
            {
                var options = new DbContextOptionsBuilder<ProsjektContext>()
                    .UseInMemoryDatabase(databaseName: "ProsjektDB")
                    .Options;

                _context = new ProsjektContext(options);

                // Seed the database with test data
                _context.Parts.Add(new Part { PartID_int = 1, Quantity_available_int = 10 });
                _context.SaveChanges();
            }
        }

        [Test]
        public void UpdateQuantity_Action_UpdatesQuantityAndRedirects()
        {
            // Arrange
            var controller = new PartsController(_context);

            // Assuming you have a Part in the database with PartID_int = 1
            var initialQuantity = _context.Parts.First().Quantity_available_int;
            var newQuantity = initialQuantity + 5;

            // Act
            var result = controller.UpdateQuantity(1, newQuantity) as RedirectToActionResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Parts", result.ActionName);

            // Check if the quantity is updated
            var updatedPart = _context.Parts.First();
            Assert.AreEqual(newQuantity, updatedPart.Quantity_available_int);
        }
    }
}