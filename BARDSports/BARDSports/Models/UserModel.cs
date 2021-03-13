using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace BARDSports.Models
{
    public class UserModel
    {
        [Key]
        public virtual int UserId { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public virtual string Role { get; set; }

    }
}