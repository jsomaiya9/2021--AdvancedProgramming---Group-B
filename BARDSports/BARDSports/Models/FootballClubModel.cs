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
        public virtual int FootballClubId { get; set; }
        public virtual int LeagueId { get; set; }
        public virtual string FootballClubName { get; set; }
        public virtual string Goals { get; set; }
        public virtual string Passes { get; set; }
        public virtual string Cleansheets { get; set; }
        public virtual LeagueModel League { get; set; }

    }
}