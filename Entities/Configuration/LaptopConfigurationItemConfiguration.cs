using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class LaptopConfigurationItemConfiguration : IEntityTypeConfiguration<LaptopConfigurationItem>
    {
        public void Configure(EntityTypeBuilder<LaptopConfigurationItem> builder)
        {
            builder.HasData(
                new LaptopConfigurationItem
                {
                    ConfigurationItemId = 1,
                    ItemName = "Ram"
                },
                new LaptopConfigurationItem
                {
                    ConfigurationItemId = 2,
                    ItemName = "HDD"
                },
                new LaptopConfigurationItem
                {
                    ConfigurationItemId = 3,
                    ItemName = "Colour"
                }
                );
        }
    }
}