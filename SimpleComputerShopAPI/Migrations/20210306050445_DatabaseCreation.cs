using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SimpleComputerShopAPI.Migrations
{
    public partial class DatabaseCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConfigurationCosts",
                columns: table => new
                {
                    ConfigurationCostId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ConfigurationItemId = table.Column<int>(nullable: false),
                    Option = table.Column<string>(nullable: false),
                    Cost = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigurationCosts", x => x.ConfigurationCostId);
                });

            migrationBuilder.CreateTable(
                name: "LaptopBrands",
                columns: table => new
                {
                    BrandId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BrandName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaptopBrands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "LaptopConfigurationItems",
                columns: table => new
                {
                    ConfigurationItemId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ItemName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaptopConfigurationItems", x => x.ConfigurationItemId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConfigurationCosts_ConfigurationItemId",
                table: "ConfigurationCosts",
                column: "ConfigurationItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LaptopBrands_BrandName",
                table: "LaptopBrands",
                column: "BrandName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LaptopConfigurationItems_ItemName",
                table: "LaptopConfigurationItems",
                column: "ItemName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfigurationCosts");

            migrationBuilder.DropTable(
                name: "LaptopBrands");

            migrationBuilder.DropTable(
                name: "LaptopConfigurationItems");
        }
    }
}
