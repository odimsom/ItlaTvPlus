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
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Primary key

            modelBuilder.Entity<Gender>().HasKey(g => g.Id);            
            modelBuilder.Entity<Producer>().HasKey(p => p.Id);            
            modelBuilder.Entity<Serie>().HasKey(s => s.Id);

            #endregion

            #region Entity relationShips

            #region Producers to Series

            modelBuilder.Entity<Producer>()
                .HasMany<Serie>(p => p.Series)
                .WithOne(s => s.Producer)
                .HasForeignKey(s => s.ProducerId);

            #endregion

            #region Genders to Series

            modelBuilder.Entity<Gender>()
                .HasMany(g => g.Series)
                .WithMany(s => s.Genders)
                .UsingEntity(j => j.ToTable("SeriesGenders"));

            #endregion

            #endregion

            #region Table

            modelBuilder.Entity<Gender>().ToTable("Generos");
            modelBuilder.Entity<Producer>().ToTable("Productoras");
            modelBuilder.Entity<Serie>().ToTable("Series");

            #endregion
        }
    }
}
