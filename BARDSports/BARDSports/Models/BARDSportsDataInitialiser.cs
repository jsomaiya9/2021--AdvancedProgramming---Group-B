using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BARDSports.Models
{
    public class BARDSportsDataInitialiser: DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            LeagueModel leagueModel1 = new LeagueModel();
            leagueModel1.LeagueId = 1;
            leagueModel1.LeagueName = "Premier League";
            context.LeagueModels.Add(leagueModel1);


        }
}