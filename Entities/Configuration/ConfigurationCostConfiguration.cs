using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration
{
    public class ConfigurationCostConfiguration : IEntityTypeConfiguration<ConfigurationCost>
    {
        public void Configure(EntityTypeBuilder<ConfigurationCost> builder)
        {
            builder.HasData(
                new ConfigurationCost
                {
                    ConfigurationCostId = 1,
                    ConfigurationItemId = 1,
                    Option = "8 GB",
                    Cost = Convert.ToInt64(45.67 * 100)
                },
                new ConfigurationCost
                {
                    ConfigurationCostId = 2,
                    ConfigurationItemId = 1,
                    Option = "16 GB",
                    Cost = Convert.ToInt64(87.88 * 100)
                },
                new ConfigurationCost
                {
                    ConfigurationCostId = 3,
                    ConfigurationItemId = 2,
                    Option = "500 GB",
                    Cost = Convert.ToInt64(123.34 * 100)
                },
                new ConfigurationCost
                {
                    ConfigurationCostId = 4,
                    ConfigurationItemId = 2,
                    Option = "1 TB",
                    Cost = Convert.ToInt64(200.00 * 100)
                },
                new ConfigurationCost
                {
                    ConfigurationCostId = 5,
                    ConfigurationItemId = 3,
                    Option = "Red",
                    Cost = Convert.ToInt64(50.76 * 100)
                },
                new ConfigurationCost
                {
                    ConfigurationCostId = 6,
                    ConfigurationItemId = 3,
                    Option = "Blue",
                    Cost = Convert.ToInt64(34.56 * 100)
                }
                );
        }
    }
}