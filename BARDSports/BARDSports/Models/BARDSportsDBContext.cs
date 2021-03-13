using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BARDSports.Models
{
    public class BARDSportsDBContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BARDSportsDBContext() : base("name=BARDSportsDBContext")
        {
        }

        public System.Data.Entity.DbSet<BARDSports.Models.AdvertModel> AdvertModels { get; set; }

        public System.Data.Entity.DbSet<BARDSports.Models.LeagueModel> LeagueModels { get; set; }

        public System.Data.Entity.DbSet<BARDSports.Models.CommentsModel> CommentsModels { get; set; }

        public System.Data.Entity.DbSet<BARDSports.Models.PlayerModel> PlayerModels { get; set; }

        public System.Data.Entity.DbSet<BARDSports.Models.UserModel> UserModels { get; set; }

        public System.Data.Entity.DbSet<BARDSports.Models.FootballClubModel> FootballClubModels { get; set; }

        public System.Data.Entity.DbSet<BARDSports.Models.PlayerFansModel> PlayerFansModels { get; set; }
    }
}
