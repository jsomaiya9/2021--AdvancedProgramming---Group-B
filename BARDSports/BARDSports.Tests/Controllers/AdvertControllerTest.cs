using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BARDSports.Controllers;

namespace BARDSports.Tests.Controllers
{
    [TestClass]
    public class AdvertControllerTest
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            AdvertController Advert = new AdvertController();
            //test to see that it exists
            Assert.IsNotNull(Advert);

        }

        [TestMethod]
        public void ValidOK()
        {
            //create an instance of the class we want to create
            AdvertController Advert = new AdvertController();
            //test to see that it exists           
            Assert.IsNotNull(Advert);
        }

        [TestMethod]
        public void DescriptionOK()
        {
            //create an instance of the class we want to create
            AdvertController Advert = new AdvertController();
            //create some test data to assign to the property
            string ADescription = "";
            //assign the data to the property
            Advert.Description = ADescription;
            //test to see that it exists
            Assert.AreEqual(Advert.Description, ADescription);

        }

            ////good test data
            ////create some test data to pass to the method
            //string Index = "Salman";
            //string LastName = "Khan";

            //[TestMethod]
            //public void Index()
            //{
            //    // Arrange
            //    AdvertController controller = new AdvertController();

            //    // Act
            //    ViewResult result = controller.Index() as ViewResult;

            //    // Assert
            //    Assert.IsNotNull(result);
            //}

            //[TestMethod]
            //public void Details()
            //{
            //    // Arrange
            //    AdvertController controller = new AdvertController();

            //    // Act
            //    ViewResult result = controller.Details() as ViewResult;

            //    // Assert
            //    Assert.AreEqual("Your application description page.", result.ViewBag.Message);
            //}

            //[TestMethod]
            //public void Create()
            //{
            //    // Arrange
            //    AdvertController controller = new AdvertController();

            //    // Act
            //    ViewResult result = controller.Create() as ViewResult;

            //    // Assert
            //    Assert.IsNotNull(result);
            //}
        }
}
