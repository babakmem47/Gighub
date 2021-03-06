﻿
namespace Gighub.Notes
{
    public class MyNotes
    {
        // Save all :           Alt+F, L
        // Clean workspace:     Alt+W, L
        //




        //////////////////////////////////////////////////////// Overriding Conventions using FluentApi //////////////////////////////////////

        // 1. Create a Folder and name it: EntityConfigurations

        // 2. Add a public class in this folder for each model:         for example: GigConfiguration.cs

        // 3. Make this class derive from EntityTypeConfiguration<> :   for example: public class GigConfiguration : EntityTypeConfiguration<Gig>
        //                                                                           {
        //                                                                           }                                                                                   

        // 4.Create constructor and insert Fluent Api :
        //        public GigConfiguration()
        //        {
        //            HasKey(g => g.Id);
        //
        //            Property(g => g.ArtistId)
        //                .IsRequired();
        //
        //            Property(g => g.Venue)
        //                .IsRequired()
        //                .HasMaxLength(255);
        //
        //            Property(g => g.GenreId)
        //                .IsRequired();
        //
        //        }

        // 5. in ApplicationDbContext.cs class after definition of DbSet<> for classes, type 'onModel' to create below method:
        //        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //        {
        //            base.OnModelCreating(modelBuilder);
        //        }

        // 6. insert this line of code to look like below:
        //        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //        {
        //            modelBuilder.Configurations.Add(new GigConfiguration());
        //
        //            modelBuilder.Configurations.Add(new GenreConfiguration());
        //
        //            base.OnModelCreating(modelBuilder);
        //
        //        }
        // 7. 

    }
}