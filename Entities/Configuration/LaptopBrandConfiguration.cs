using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class LaptopBrandConfiguration : IEntityTypeConfiguration<LaptopBrand>
    {
        public void Configure(EntityTypeBuilder<LaptopBrand> builder)
        {
            builder.HasData(
                new LaptopBrand
                {
                    BrandId = 1,
                    BrandName = "Dell",
                    Cost = Convert.ToInt64(349.87 * 100)
                },
                new LaptopBrand
                {
                    BrandId = 2,
                    BrandName = "Toshiba",
                    Cost = Convert.ToInt64(345.67 * 100)
                },
                new LaptopBrand
                {
                    BrandId = 3,
                    BrandName = "HP",
                    Cost = Convert.ToInt64(456.76 * 100)
                }
                );
        }
    }
}