namespace Gighub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DisableIdentityForPrimaryKeyOfGenreAndGig : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Gigs", "GenreId", "dbo.Genres");
            DropPrimaryKey("dbo.Genres");
            DropPrimaryKey("dbo.Gigs");
            AlterColumn("dbo.Genres", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Gigs", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Genres", "Id");
            AddPrimaryKey("dbo.Gigs", "Id");
            AddForeignKey("dbo.Gigs", "GenreId", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gigs", "GenreId", "dbo.Genres");
            DropPrimaryKey("dbo.Gigs");
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Gigs", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Genres", "Id", c => c.Byte(nullable: false, identity: true));
            AddPrimaryKey("dbo.Gigs", "Id");
            AddPrimaryKey("dbo.Genres", "Id");
            AddForeignKey("dbo.Gigs", "GenreId", "dbo.Genres", "Id");
        }
    }
}
