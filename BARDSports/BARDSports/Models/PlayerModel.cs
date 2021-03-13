using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BARDSports.Models
{
    public class PlayerModel
    {
        [Key]
        public virtual int PlayerId { get; set; }
        public virtual int FootballClubId { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string Lastname { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public virtual string Position { get; set; }
        public virtual string Goals { get; set; }
        public virtual string Assists { get; set; }
        public virtual string YellowCards { get; set; }
        public virtual string RedCards { get; set; }
        public virtual FootballClubModel Football { get; set; }

    }
}