using ItlaTvPlus.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ItlaTvPlus.Persitence.Context
{
    public class ItlaTvPlusContext : DbContext
    {

        public ItlaTvPlusContext(DbContextOptions<ItlaTvPlusContext> options) : base(options)
        {

        }

        #region DbSets of entities
        public DbSet<Serie> Series { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<SeriesGenders> SeriesGenders { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Fluent api
            #region Primary key

            modelBuilder.Entity<Gender>()
                .HasKey(g => g.Id);
            
            modelBuilder.Entity<Producer>()
                .HasKey(p => p.Id);
            
            modelBuilder.Entity<Serie>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<SeriesGenders>()
                .HasKey(sg => new { sg.SerieId, sg.GenderId });

            #endregion

            #region SerieGender (many to many explicited)

            modelBuilder.Entity<SeriesGenders>()
                .HasOne(sg => sg.Serie)
                .WithMany(s => s.SerieGenders)
                .HasForeignKey(sg => sg.SerieId);

            modelBuilder.Entity<SeriesGenders>()
                .HasOne(sg => sg.Gender)
                .WithMany(g => g.SerieGenders)
                .HasForeignKey(sg => sg.GenderId);

            #endregion

            #region Table

            modelBuilder.Entity<Gender>()
                .ToTable("Generos");

            modelBuilder.Entity<Producer>()
                .ToTable("Productoras");

            modelBuilder.Entity<Serie>()
                .ToTable("Series");

            modelBuilder.Entity<SeriesGenders>()
                .ToTable("SeriesGenders");

            #region Set Defalult Value Remove
            modelBuilder.Entity<Gender>().Property(g => g.Remuve).HasDefaultValue(false);
            modelBuilder.Entity<Producer>().Property(p => p.Remuve).HasDefaultValue(false);
            modelBuilder.Entity<Serie>().Property(s => s.Remuve).HasDefaultValue(false);
            #endregion

            #endregion
        }
    }
}
