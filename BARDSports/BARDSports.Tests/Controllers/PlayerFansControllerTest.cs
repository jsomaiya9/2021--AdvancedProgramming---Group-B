using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BARDSports.Controllers;

namespace BARDSports.Tests.Controllers
{
    [TestClass]
    public class PlayerFansControllerTest
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            PlayerFansController PlayerFan = new PlayerFansController();
            //test to see that it exists
            Assert.IsNotNull(PlayerFan);

        }

        [TestMethod]
        public void ValidOK()
        {
            //create an instance of the class we want to create
            PlayerFansController PlayerFan= new PlayerFansController();
            //test to see that it exists           
            Assert.IsNotNull(PlayerFan);
        }
    }
}
