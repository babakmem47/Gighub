namespace Gighub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateApplicationUserIdAndMakeItRequired : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Gigs", "Artist_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Gigs", new[] { "Artist_Id" });
            RenameColumn(table: "dbo.Gigs", name: "Artist_Id", newName: "ApplicationUserId");
            AlterColumn("dbo.Gigs", "ApplicationUserId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Gigs", "ApplicationUserId");
            AddForeignKey("dbo.Gigs", "ApplicationUserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gigs", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.Gigs", new[] { "ApplicationUserId" });
            AlterColumn("dbo.Gigs", "ApplicationUserId", c => c.String(maxLength: 128));
            RenameColumn(table: "dbo.Gigs", name: "ApplicationUserId", newName: "Artist_Id");
            CreateIndex("dbo.Gigs", "Artist_Id");
            AddForeignKey("dbo.Gigs", "Artist_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
