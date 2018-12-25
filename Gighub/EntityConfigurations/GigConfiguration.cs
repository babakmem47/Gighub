using Gighub.Models;
using System.Data.Entity.ModelConfiguration;

namespace Gighub.EntityConfigurations
{
    public class GigConfiguration : EntityTypeConfiguration<Gig>
    {
        public GigConfiguration()
        {
            HasKey(g => g.Id);

            Property(g => g.ArtistId)
                .IsRequired();

            Property(g => g.Venue)
                .IsRequired()
                .HasMaxLength(255);

            Property(g => g.GenreId)
                .IsRequired();

            /////// Relation /////////////
            // Many-To-One With Genre
            HasRequired(g => g.Genre)
                .WithMany(gn => gn.Gigs)
                .HasForeignKey(g => g.GenreId);


            // Many-To-One With Artist
            // ???


        }

    }
}