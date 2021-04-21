using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BARDSports.Models
{
    
    public class FootballClubModel
    {
        [Key]
        //Encapsulation get, set methods
        public virtual int FootballClubId { get; set; }//primary key
        public virtual int LeagueId { get; set; }//foreign key
        public virtual string FootballClubName { get; set; }
        public virtual string Goals { get; set; }
        public virtual string Passes { get; set; }
        public virtual string Cleansheets { get; set; }
        public virtual string Wins { get; set; }
        public virtual string Draws { get; set; }
        public virtual string Lost { get; set; }

        public virtual string Points { get; set; }

        public virtual LeagueModel League { get; set; }




    }
}