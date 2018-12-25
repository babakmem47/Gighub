namespace Gighub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveArtistIdFromGig : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Gigs", "ArtistId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Gigs", "ArtistId", c => c.Int(nullable: false));
        }
    }
}
