namespace BARDSports.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeIdToUserId : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.CommentsModels", name: "Id", newName: "UserId");
            RenameIndex(table: "dbo.CommentsModels", name: "IX_Id", newName: "IX_UserId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.CommentsModels", name: "IX_UserId", newName: "IX_Id");
            RenameColumn(table: "dbo.CommentsModels", name: "UserId", newName: "Id");
        }
    }
}
