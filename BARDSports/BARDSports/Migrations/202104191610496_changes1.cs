namespace BARDSports.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes1 : DbMigration
    {
        public override void Up()
        {
            ////DropForeignKey("dbo.CommentsModels", "ApplicationUser_Id", "dbo.AspNetUsers");
            ////DropIndex("dbo.CommentsModels", new[] { "ApplicationUser_Id" });
            //DropIndex("dbo.CommentsModels", new[] { "User_Id" });
            //DropColumn("dbo.CommentsModels", "Id");
            //RenameColumn(table: "dbo.CommentsModels", name: "User_Id", newName: "Id");
            //AlterColumn("dbo.CommentsModels", "Id", c => c.String(maxLength: 128));
            //CreateIndex("dbo.CommentsModels", "Id");
            //DropColumn("dbo.CommentsModels", "ApplicationUser_Id");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.CommentsModels", "ApplicationUser_Id", c => c.String(maxLength: 128));
            //DropIndex("dbo.CommentsModels", new[] { "Id" });
            //AlterColumn("dbo.CommentsModels", "Id", c => c.String());
            //RenameColumn(table: "dbo.CommentsModels", name: "Id", newName: "User_Id");
            //AddColumn("dbo.CommentsModels", "Id", c => c.String());
            //CreateIndex("dbo.CommentsModels", "User_Id");
            //CreateIndex("dbo.CommentsModels", "ApplicationUser_Id");
            //AddForeignKey("dbo.CommentsModels", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
