namespace Gighub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeGenresPrimaryKeyIdentityTrueWithFluentApi : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Gigs", "GenreId", "dbo.Genres");
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Genres", "Id", c => c.Byte(nullable: false, identity: true));
            AddPrimaryKey("dbo.Genres", "Id");
            AddForeignKey("dbo.Gigs", "GenreId", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gigs", "GenreId", "dbo.Genres");
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Genres", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Genres", "Id");
            AddForeignKey("dbo.Gigs", "GenreId", "dbo.Genres", "Id");
        }
    }
}
