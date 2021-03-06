﻿// <auto-generated />
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SimpleComputerShopAPI.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Entities.Models.ConfigurationCost", b =>
                {
                    b.Property<int>("ConfigurationCostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ConfigurationCostId")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ConfigurationItemId")
                        .HasColumnType("integer");

                    b.Property<long>("Cost")
                        .HasColumnType("bigint");

                    b.Property<string>("Option")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ConfigurationCostId");

                    b.HasIndex("ConfigurationItemId")
                        .IsUnique();

                    b.ToTable("ConfigurationCosts");
                });

            modelBuilder.Entity("Entities.Models.LaptopBrand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("BrandId")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("BrandId");

                    b.HasIndex("BrandName")
                        .IsUnique();

                    b.ToTable("LaptopBrands");
                });

            modelBuilder.Entity("Entities.Models.LaptopConfigurationItem", b =>
                {
                    b.Property<int>("ConfigurationItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ConfigurationItemId")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ConfigurationItemId");

                    b.HasIndex("ItemName")
                        .IsUnique();

                    b.ToTable("LaptopConfigurationItems");
                });
#pragma warning restore 612, 618
        }
    }
}
