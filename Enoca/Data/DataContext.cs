using Microsoft.EntityFrameworkCore;
using Enoca.Models;

namespace Enoca.Data
{
    public class DataContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Buraya kendi MySQL baðlantý cümleni yaz!
                optionsBuilder.UseMySql(
                    "server=127.0.0.1;database=pokemonreview2;user=feza;password=feza28;",
                    new MySqlServerVersion(new Version(8, 0, 36))
                );
            }
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DataContext() { }

        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }
        public DbSet<Pokemon_Owner> Pokemon_Owners { get; set; }
        public DbSet<Pokemon_Category> Pokemon_Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pokemon_Category>()
                .HasKey(pc => new { pc.PokemonId, pc.CategoryId });
            modelBuilder.Entity<Pokemon_Category>()
                .HasOne(p => p.Pokemon)
                .WithMany(pc => pc.Pokemon_Categories)
                .HasForeignKey(c => c.PokemonId);
            modelBuilder.Entity<Pokemon_Category>()
                .HasOne(p => p.Category)
                .WithMany(pc => pc.Pokemon_Categories)
                .HasForeignKey(c => c.CategoryId);


            modelBuilder.Entity<Pokemon_Owner>()
                .HasKey(po => new { po.PokemonId, po.OwnerId });
            modelBuilder.Entity<Pokemon_Owner>()
                .HasOne(p => p.Pokemon)
                .WithMany(pc => pc.Pokemon_Owners)
                .HasForeignKey(c => c.PokemonId);
            modelBuilder.Entity<Pokemon_Owner>()
                .HasOne(p => p.Owner)
                .WithMany(pc => pc.Pokemon_Owners)
                .HasForeignKey(c => c.OwnerId);

        }
    }
} 