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
        public virtual int AdvertId { get; set; }
        public virtual int LeagueId { get; set; }
        public virtual string Description { get; set; }
        public virtual string Image { get; set; }
        public virtual LeagueModel League { get; set; }

    }
}