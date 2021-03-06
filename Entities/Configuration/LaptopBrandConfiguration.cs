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
                    BrandName = "Dell"
                },
                new LaptopBrand
                {
                    BrandId = 2,
                    BrandName = "Toshiba"
                },
                new LaptopBrand
                {
                    BrandId = 3,
                    BrandName = "HP"
                }
                );
        }
    }
}