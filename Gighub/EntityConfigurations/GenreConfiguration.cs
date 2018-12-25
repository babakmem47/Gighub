using Gighub.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gighub.EntityConfigurations
{
    public class GenreConfiguration : EntityTypeConfiguration<Genre>
    {
        public GenreConfiguration()
        {
            HasKey(gn => gn.Id);

            Property(gn => gn.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            Property(gn => gn.Name)
                .IsRequired()
                .HasMaxLength(222);

            /////// Relation /////////////
            // One-To-Many with Gig
            HasMany(gn => gn.Gigs)
                .WithRequired(g => g.Genre)
                .WillCascadeOnDelete(false);



        }
    }
}