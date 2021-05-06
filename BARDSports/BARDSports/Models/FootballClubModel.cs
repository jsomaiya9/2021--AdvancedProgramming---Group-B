using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BARDSports.Models
{
    
    public class FootballClubModel
    {
        //Encapsulation get, set methods
        [Key]        
        public virtual int FootballClubId { get; set; }//primary key
        public virtual int LeagueId { get; set; }//foreign key
        public virtual string FootballClubName { get; set; }
        public virtual int Goals { get; set; }
        public virtual int Passes { get; set; }
        public virtual int Cleansheets { get; set; }
        public virtual int Wins { get; set; }
        public virtual int Draws { get; set; }
        public virtual int Lost { get; set; }
        public virtual int Points { get; set; }
        //set foreign key
        public virtual LeagueModel League { get; set; }

        //method with parameters
        //create valid string
        public string valid(int Passes, int Cleansheets, int Wins, int Draws, int Lost, int Points)
        {
            string ErrorMessage = "";
            //Passes
            if(Passes < 0)
            {
                ErrorMessage = "Too low";
            }
            if(Passes > 40)
            {
                ErrorMessage = "Too high";
            }
            //Cleansheets
            if(Cleansheets < 0)
            {
                ErrorMessage = "Too low";
            }
            if(Cleansheets > 38)
            {
                ErrorMessage = "Too high";
            }
            //Wins
            if (Wins < 0)
            {
                ErrorMessage = "Too low";
            }
            if (Wins > 38)
            {
                ErrorMessage = "Too high";
            }
            //Draws
            if (Draws < 0)
            {
                ErrorMessage = "Too low";
            }
            if (Draws > 38)
            {
                ErrorMessage = "Too high";
            }
            //Lost
            if (Lost < 0)
            {
                ErrorMessage = "Too low";
            }
            if (Lost > 38)
            {
                ErrorMessage = "Too high";
            }
            //Points
            if (Points < 0)
            {
                ErrorMessage = "Too low";
            }
            if (Points > 114)
            {
                ErrorMessage = "Too high";
            }
            return ErrorMessage;
        }


    }
}