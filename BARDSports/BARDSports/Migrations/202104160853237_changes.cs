namespace BARDSports.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.PlayerFansModels",
            //    c => new
            //    {
            //        PlayerFansId = c.Int(nullable: false, identity: true),
            //        PlayerId = c.Int(nullable: false),
            //        Id = c.String(maxLength: 128),
            //    })
            //    .PrimaryKey(t => t.PlayerFansId)
            //    .ForeignKey("dbo.PlayerModels", t => t.PlayerId, cascadeDelete: true)
            //    .ForeignKey("dbo.AspNetUsers", t => t.Id)
            //    .Index(t => t.PlayerId)
            //    .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.PlayerFansModels", "Id", "dbo.AspNetUsers");
            //DropForeignKey("dbo.PlayerFansModels", "PlayerId", "dbo.PlayerModels");
            DropIndex("dbo.PlayerFansModels", new[] { "Id" });
            DropIndex("dbo.PlayerFansModels", new[] { "PlayerId" });
            DropTable("dbo.PlayerFansModels");
        }
    }
}
