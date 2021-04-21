using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BARDSports.Controllers;

namespace BARDSports.Tests.Controllers
{
    [TestClass]
    public class LeagueControllerTest
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            LeagueController League = new LeagueController();
            //test to see that it exists
            Assert.IsNotNull(League);

        }

        [TestMethod]
        public void ValidOK()
        {
            //create an instance of the class we want to create
            LeagueController League = new LeagueController();
            //test to see that it exists           
            Assert.IsNotNull(League);
        }
    }
}
