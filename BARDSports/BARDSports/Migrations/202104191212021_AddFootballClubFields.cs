namespace BARDSports.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFootballClubFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FootballClubModels", "Wins", c => c.String());
            AddColumn("dbo.FootballClubModels", "Draws", c => c.String());
            AddColumn("dbo.FootballClubModels", "Lost", c => c.String());
            AddColumn("dbo.FootballClubModels", "Points", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FootballClubModels", "Points");
            DropColumn("dbo.FootballClubModels", "Lost");
            DropColumn("dbo.FootballClubModels", "Draws");
            DropColumn("dbo.FootballClubModels", "Wins");
        }
    }
}
