namespace BARDSports.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.AdvertModels",
            //    c => new
            //        {
            //            AdvertId = c.Int(nullable: false, identity: true),
            //            LeagueId = c.Int(nullable: false),
            //            Description = c.String(),
            //            Image = c.String(),
            //        })
            //    .PrimaryKey(t => t.AdvertId)
            //    .ForeignKey("dbo.LeagueModels", t => t.LeagueId, cascadeDelete: true)
            //    .Index(t => t.LeagueId);

            CreateTable(
                "dbo.LeagueModels",
                c => new
                {
                    LeagueId = c.Int(nullable: false, identity: true),
                    LeagueName = c.String(),
                    Description = c.String(),
                    Seasons = c.String(),
                })
                .PrimaryKey(t => t.LeagueId);

            CreateTable(
                "dbo.CommentsModels",
                c => new
                {
                    CommentsId = c.Int(nullable: false, identity: true),
                    PlayerId = c.Int(nullable: false),
                    Id = c.String(maxLength: 128),
                    Rating = c.String(),
                    Date = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.CommentsId)
                .ForeignKey("dbo.PlayerModels", t => t.PlayerId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.Id)
                .Index(t => t.PlayerId)
                .Index(t => t.Id);

            CreateTable(
                "dbo.PlayerModels",
                c => new
                {
                    PlayerId = c.Int(nullable: false, identity: true),
                    FootballClubId = c.Int(nullable: false),
                    Firstname = c.String(),
                    Lastname = c.String(),
                    DateOfBirth = c.DateTime(nullable: false),
                    Position = c.String(),
                    Goals = c.String(),
                    Assists = c.String(),
                    YellowCards = c.String(),
                    RedCards = c.String(),
                })
                .PrimaryKey(t => t.PlayerId)
                .ForeignKey("dbo.FootballClubModels", t => t.FootballClubId, cascadeDelete: true)
                .Index(t => t.FootballClubId);

            CreateTable(
                "dbo.FootballClubModels",
                c => new
                {
                    FootballClubId = c.Int(nullable: false, identity: true),
                    LeagueId = c.Int(nullable: false),
                    FootballClubName = c.String(),
                    Goals = c.String(),
                    Passes = c.String(),
                    Cleansheets = c.String(),
                })
                .PrimaryKey(t => t.FootballClubId)
                .ForeignKey("dbo.LeagueModels", t => t.LeagueId, cascadeDelete: true)
                .Index(t => t.LeagueId);

            CreateTable(
                "dbo.AspNetUsers",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Email = c.String(maxLength: 256),
                    EmailConfirmed = c.Boolean(nullable: false),
                    PasswordHash = c.String(),
                    SecurityStamp = c.String(),
                    PhoneNumber = c.String(),
                    PhoneNumberConfirmed = c.Boolean(nullable: false),
                    TwoFactorEnabled = c.Boolean(nullable: false),
                    LockoutEndDateUtc = c.DateTime(),
                    LockoutEnabled = c.Boolean(nullable: false),
                    AccessFailedCount = c.Int(nullable: false),
                    UserName = c.String(nullable: false, maxLength: 256),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");

            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    UserId = c.String(nullable: false, maxLength: 128),
                    ClaimType = c.String(),
                    ClaimValue = c.String(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);

            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                {
                    LoginProvider = c.String(nullable: false, maxLength: 128),
                    ProviderKey = c.String(nullable: false, maxLength: 128),
                    UserId = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);

            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                {
                    UserId = c.String(nullable: false, maxLength: 128),
                    RoleId = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);

            CreateTable(
                "dbo.AspNetRoles",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Name = c.String(nullable: false, maxLength: 256),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");

        }

        public override void Down()
        {
            //DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            //DropForeignKey("dbo.CommentsModels", "Id", "dbo.AspNetUsers");
            //DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            //DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            //DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            //DropForeignKey("dbo.CommentsModels", "PlayerId", "dbo.PlayerModels");
            //DropForeignKey("dbo.PlayerModels", "FootballClubId", "dbo.FootballClubModels");
            //DropForeignKey("dbo.FootballClubModels", "LeagueId", "dbo.LeagueModels");
            //DropForeignKey("dbo.AdvertModels", "LeagueId", "dbo.LeagueModels");
            //DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            //DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            //DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            //DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            //DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            //DropIndex("dbo.AspNetUsers", "UserNameIndex");
            //DropIndex("dbo.FootballClubModels", new[] { "LeagueId" });
            //DropIndex("dbo.PlayerModels", new[] { "FootballClubId" });
            //DropIndex("dbo.CommentsModels", new[] { "Id" });
            //DropIndex("dbo.CommentsModels", new[] { "PlayerId" });
            //DropIndex("dbo.AdvertModels", new[] { "LeagueId" });
            //DropTable("dbo.AspNetRoles");
            //DropTable("dbo.AspNetUserRoles");
            //DropTable("dbo.AspNetUserLogins");
            //DropTable("dbo.AspNetUserClaims");
            //DropTable("dbo.AspNetUsers");
            //DropTable("dbo.FootballClubModels");
            //DropTable("dbo.PlayerModels");
            //DropTable("dbo.CommentsModels");
            //DropTable("dbo.LeagueModels");
            //DropTable("dbo.AdvertModels");
        }
    }
}
