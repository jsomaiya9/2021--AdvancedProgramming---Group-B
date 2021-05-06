using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BARDSports.Controllers;
using BARDSports.Models;

namespace BARDSports.Tests.Controllers
{
    [TestClass]
    public class FootballClubControllerTest
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            FootballClubController FootballClub = new FootballClubController();
            //test to see that it exists
            Assert.IsNotNull(FootballClub);

        }

        [TestMethod]
        public void ValidOK()
        {
            //create an instance of the class we want to create
            FootballClubController FootballClub = new FootballClubController();
            //test to see that it exists           
            Assert.IsNotNull(FootballClub);
        }

        //Passes
        [TestMethod]
        public void Passes_Min()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 0;
            Int32 Wins = 0;
            Int32 Draws = 0;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Passes_MinPlus1()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 1;
            Int32 Cleansheets = 0;
            Int32 Wins = 0;
            Int32 Draws = 0;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets,Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "");
        }

       
        [TestMethod]
        public void Passes_Mid()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 26;
            Int32 Cleansheets = 0;
            Int32 Wins = 0;
            Int32 Draws = 0;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "");
        }

       

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Passes_Invalid()
        {
            FootballClubModel footballClub = new FootballClubModel();
            footballClub.Passes = Convert.ToInt32("mayistandunshaken");

        }

        //Cleansheets
        [TestMethod]
        public void Cleansheets_Min()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 0;
            Int32 Wins = 0;
            Int32 Draws = 0;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes,Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Cleansheets_MinPlus1()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 1;
            Int32 Wins = 1;
            Int32 Draws = 0;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "");
        }
        
        [TestMethod]
        public void Cleansheets_MaxMinus1()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 37;
            Int32 Wins = 37;
            Int32 Draws = 0;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Cleansheets_Max()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 38;
            Int32 Wins = 38;
            Int32 Draws = 0;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Cleansheets_MaxPlus1()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 39;
            Int32 Wins = 39;
            Int32 Draws = 0;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "Too high");
        }

        [TestMethod]
        public void Cleansheets_ExtremeMax()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 99;
            Int32 Wins = 99;
            Int32 Draws = 0;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "Too high");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Cleansheets_Invalid()
        {
            FootballClubModel footballClub = new FootballClubModel();
            footballClub.Passes = Convert.ToInt32("mayistandunshaken");

        }

        //Wins
        [TestMethod]
        public void Wins_Min()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 0;
            Int32 Wins = 0;
            Int32 Draws = 0;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Wins_MinPlus1()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 1;
            Int32 Wins = 1;
            Int32 Draws = 0;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Wins_MaxMinus1()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 37;
            Int32 Wins = 37;
            Int32 Draws = 0;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Wins_Max()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 38;
            Int32 Wins = 38;
            Int32 Draws = 0;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Wins_MaxPlus1()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 39;
            Int32 Wins = 39;
            Int32 Draws = 0;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "Too high");
        }

        [TestMethod]
        public void Wins_ExtremeMax()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 99;
            Int32 Wins = 99;
            Int32 Draws = 0;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "Too high");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Wins_Invalid()
        {
            FootballClubModel footballClub = new FootballClubModel();
            footballClub.Wins = Convert.ToInt32("mayistandunshaken");

        }

        //Draws
        [TestMethod]
        public void Draws_Min()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 0;
            Int32 Wins = 0;
            Int32 Draws = 0;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Draws_MinPlus1()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 1;
            Int32 Wins = 1;
            Int32 Draws = 1;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Draws_MaxMinus1()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 37;
            Int32 Wins = 37;
            Int32 Draws = 37;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Draws_Max()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 38;
            Int32 Wins = 38;
            Int32 Draws = 38;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Draws_MaxPlus1()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 39;
            Int32 Wins = 39;
            Int32 Draws = 38;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "Too high");
        }

        [TestMethod]
        public void Draws_ExtremeMax()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 99;
            Int32 Wins = 99;
            Int32 Draws = 99;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "Too high");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Draws_Invalid()
        {
            FootballClubModel footballClub = new FootballClubModel();
            footballClub.Wins = Convert.ToInt32("mayistandunshaken");

        }

        //Lost
        [TestMethod]
        public void Lost_Min()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 0;
            Int32 Wins = 0;
            Int32 Draws = 0;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Lost_MinPlus1()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 1;
            Int32 Wins = 1;
            Int32 Draws = 0;
            Int32 Lost = 1;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Lost_MaxMinus1()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 37;
            Int32 Wins = 37;
            Int32 Draws = 0;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Lost_Max()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 38;
            Int32 Wins = 38;
            Int32 Draws = 0;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Lost_MaxPlus1()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 39;
            Int32 Wins = 39;
            Int32 Draws = 0;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "Too high");
        }

        [TestMethod]
        public void Lost_ExtremeMax()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 99;
            Int32 Wins = 99;
            Int32 Draws = 0;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "Too high");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Lost_Invalid()
        {
            FootballClubModel footballClub = new FootballClubModel();
            footballClub.Wins = Convert.ToInt32("mayistandunshaken");

        }

        //Points
        [TestMethod]
        public void Points_Min()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 0;
            Int32 Wins = 0;
            Int32 Draws = 0;
            Int32 Lost = 0;
            Int32 Points = 0;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Points_MinPlus1()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 1;
            Int32 Wins = 1;
            Int32 Draws = 1;
            Int32 Lost = 0;
            Int32 Points = 1;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Points_MaxMinus1()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 37;
            Int32 Wins = 37;
            Int32 Draws = 37;
            Int32 Lost = 0;
            Int32 Points = 113;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Points_Max()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 38;
            Int32 Wins = 38;
            Int32 Draws = 38;
            Int32 Lost = 0;
            Int32 Points = 114;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Points_MaxPlus1()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 39;
            Int32 Wins = 39;
            Int32 Draws = 38;
            Int32 Lost = 0;
            Int32 Points = 115;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "Too high");
        }

        [TestMethod]
        public void points_ExtremeMax()
        {
            FootballClubModel footballClub = new FootballClubModel();
            //test data to assign to the test
            Int32 passes = 0;
            Int32 Cleansheets = 99;
            Int32 Wins = 99;
            Int32 Draws = 99;
            Int32 Lost = 0;
            Int32 Points = 1000;
            string valid = footballClub.valid(passes, Cleansheets, Wins, Draws, Lost, Points);
            //Test
            Assert.AreEqual(valid, "Too high");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Points_Invalid()
        {
            FootballClubModel footballClub = new FootballClubModel();
            footballClub.Points = Convert.ToInt32("mayistandunshaken");

        }

    }
}
