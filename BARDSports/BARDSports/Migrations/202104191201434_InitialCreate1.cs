namespace BARDSports.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            //DropColumn("dbo.FootballClubModels", "Wins");
            //DropColumn("dbo.FootballClubModels", "Draws");
            //DropColumn("dbo.FootballClubModels", "Lost");
            //DropColumn("dbo.FootballClubModels", "Points");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FootballClubModels", "Points", c => c.String());
            AddColumn("dbo.FootballClubModels", "Lost", c => c.String());
            AddColumn("dbo.FootballClubModels", "Draws", c => c.String());
            AddColumn("dbo.FootballClubModels", "Wins", c => c.String());
        }
    }
}
