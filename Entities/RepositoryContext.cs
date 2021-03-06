using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options): base(options)
        {
        }

        public DbSet<LaptopBrand> LaptopBrands { get; set; }
        public DbSet<LaptopConfigurationItem> LaptopConfigurationItems { get; set; }
        public DbSet<ConfigurationCost> ConfigurationCosts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LaptopBrand>(entity =>
            {
                entity.HasKey(e => e.BrandId);

                entity.HasIndex(e => e.BrandName)
                    .IsUnique();
            });

            modelBuilder.Entity<LaptopConfigurationItem>(entity =>
            {
                entity.HasKey(e => e.ConfigurationItemId);

                entity.HasIndex(e => e.ItemName)
                    .IsUnique();
            });

            modelBuilder.Entity<ConfigurationCost>(entity =>
            {
                entity.HasKey(e => e.ConfigurationCostId);

                entity.HasIndex(e => e.ConfigurationItemId)
                    .IsUnique();
            });
        }
    }
}