using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;

namespace ProductSalesPointTest
{
    public class MyTestClass
    {

    }]
    public class UnitTestSale
    { 
    [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            // Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Product()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Product() as ViewResult;

            // Assert
            // Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Categorie()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Categorie() as ViewResult;

            // Assert
            // Assert.IsNotNull(result);
        }
    }
}
