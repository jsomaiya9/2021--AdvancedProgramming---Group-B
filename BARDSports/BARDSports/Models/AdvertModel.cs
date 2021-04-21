using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BARDSports.Models
{

    public class AdvertModel
    {
      
        [Key]
        //Encapsulation get, set methods
        public virtual int AdvertId { get; set; }//primary key        
        public virtual int LeagueId { get; set;}//foreign key
        public virtual string Description { get; set; }
        public virtual string Image { get; set; }
        public virtual LeagueModel League { get; set; }

    }
}