using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BARDSports.Controllers;

namespace BARDSports.Tests.Controllers
{
    [TestClass]
    public class PlayerControllerTest
    {
       // good test data
        //create some test data to pass to the method
        string Firstname = "Hakim";
        string Lastname = "Ziyech";
        DateTime DateOfBirth = new DateTime(1993, 3, 19);
        string Position = "Midfielder";
        string Goals = "18";
        string Assists = "18";
        string YellowCards = "2";
        string RedCards = "0";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
           PlayerController Player = new PlayerController();
            //test to see that it exists
            Assert.IsNotNull(Player);

        }

        [TestMethod]
        public void ValidOK()
        {
            //create an instance of the class we want to create
            PlayerController Player = new PlayerController();
            //test to see that it exists           
            Assert.IsNotNull(Player);
        }

        [TestMethod]
        public void FirstnameOK()
        {
            //create an instance of the class we want to create
            PlayerController Player = new PlayerController();
            //create some test data to assign to the property
            string AFirstname = "Hakim";
            //assign the data to the property
            Player.Firstname = AFirstname;
            //test to see that it exists
            Assert.AreEqual(Player.Firstname, AFirstname);

        }

        [TestMethod]
        public void LastnameOK()
        {
            //create an instance of the class we want to create
            PlayerController Player = new PlayerController();
            //create some test data to assign to the property
            string ALastname = "Khan";
            //assign the data to the property
            Player.Lastname = ALastname;
            //test to see that it exists
            Assert.AreEqual(Player.Lastname, ALastname);

        }

        [TestMethod]
        public void DateOfBirthOK()
        {
            //create an instance of the class we want to create
            PlayerController Player = new PlayerController();
            //create some test data to assign to the property
            DateTime ADateOfBirth = new DateTime(1993, 3, 19);
            //assign the data to the property
           Player.DateOfBirth = ADateOfBirth;
            //test to see that it exists
            Assert.AreEqual(Player.DateOfBirth, ADateOfBirth);
        }

        [TestMethod]
        public void PositionOK()
        {
            //create an instance of the class we want to create
            PlayerController Player = new PlayerController();
            //create some test data to assign to the property
            string APosition = "Midfielder";
            //assign the data to the property
            Player.Position = APosition;
            //test to see that it exists
            Assert.AreEqual(Player.Position, APosition);

        }

        [TestMethod]
        public void GoalsOK()
        {
            //create an instance of the class we want to create
            PlayerController Player = new PlayerController();
            //create some test data to assign to the property
            string AGoals = "18";
            //assign the data to the property
            Player.Goals = AGoals;
            //test to see that it exists
            Assert.AreEqual(Player.Goals, AGoals);

        }

        [TestMethod]
        public void AssistsOK()
        {
            //create an instance of the class we want to create
            PlayerController Player = new PlayerController();
            //create some test data to assign to the property
            string AAssists= "18";
            //assign the data to the property
            Player.Assists = AAssists;
            //test to see that it exists
            Assert.AreEqual(Player.Assists, AAssists);

        }

        [TestMethod]
        public void YellowCardsOK()
        {
            //create an instance of the class we want to create
            PlayerController Player = new PlayerController();
            //create some test data to assign to the property
            string AYellowCards = "2";
            //assign the data to the property
            Player.YellowCards = AYellowCards;
            //test to see that it exists
            Assert.AreEqual(Player.YellowCards, AYellowCards);

        }

        [TestMethod]
        public void RedCardsOK()
        {
            //create an instance of the class we want to create
            PlayerController Player = new PlayerController();
            //create some test data to assign to the property
            string ARedCards = "0";
            //assign the data to the property
            Player.RedCards = ARedCards;
            //test to see that it exists
            Assert.AreEqual(Player.RedCards, ARedCards);

        }

     

    }
}
