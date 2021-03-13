using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BARDSports.Models
{
    public class CommentsModel
    {
        [Key]
        public virtual int CommentsId { get; set; }
        public virtual int PlayerId { get; set; }
        public virtual int UserId { get; set; }
        public virtual string Rating { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual PlayerModel Player { get; set; }
        public virtual UserModel User { get; set; }

    }
}