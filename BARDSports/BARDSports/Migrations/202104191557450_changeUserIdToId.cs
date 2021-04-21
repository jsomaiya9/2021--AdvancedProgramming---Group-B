namespace BARDSports.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeUserIdToId : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.CommentsModels", name: "UserId", newName: "User_Id");
            RenameIndex(table: "dbo.CommentsModels", name: "IX_UserId", newName: "IX_User_Id");
            AddColumn("dbo.CommentsModels", "Id", c => c.String());
            AddColumn("dbo.CommentsModels", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.CommentsModels", "ApplicationUser_Id");
            AddForeignKey("dbo.CommentsModels", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CommentsModels", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.CommentsModels", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.CommentsModels", "ApplicationUser_Id");
            DropColumn("dbo.CommentsModels", "Id");
            RenameIndex(table: "dbo.CommentsModels", name: "IX_User_Id", newName: "IX_UserId");
            RenameColumn(table: "dbo.CommentsModels", name: "User_Id", newName: "UserId");
        }
    }
}
