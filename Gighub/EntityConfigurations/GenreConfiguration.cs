using Gighub.Models;
using System.Data.Entity.ModelConfiguration;

namespace Gighub.EntityConfigurations
{
    public class GenreConfiguration : EntityTypeConfiguration<Genre>
    {
        public GenreConfiguration()
        {
            HasKey(gn => gn.Id);

            Property(gn => gn.Name)
                .IsRequired()
                .HasMaxLength(255);

            /////// Relation /////////////
            // One-To-Many with Gig
            HasMany(gn => gn.Gigs)
                .WithRequired(g => g.Genre)
                .WillCascadeOnDelete(false);



        }
    }
}