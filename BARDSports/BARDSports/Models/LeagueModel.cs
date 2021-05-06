using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BARDSports.Models
{
    public class LeagueModel
    {
        //Encapsulation get, set methods
        [Key]        
        public virtual int LeagueId { get; set; }//primary key
        public virtual string LeagueName { get; set; }
        public virtual string Description { get; set; }
        public virtual string Seasons { get; set; }

    }
}