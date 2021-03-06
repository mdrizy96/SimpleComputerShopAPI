using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleComputerShopAPI.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ConfigurationCosts",
                columns: new[] { "ConfigurationCostId", "ConfigurationItemId", "Cost", "Option" },
                values: new object[,]
                {
                    { 1, 1, 4567L, "8 GB" },
                    { 2, 1, 8788L, "16 GB" },
                    { 3, 2, 12334L, "500 GB" },
                    { 4, 2, 20000L, "1 TB" },
                    { 5, 3, 5076L, "Red" },
                    { 6, 3, 3456L, "Blue" }
                });

            migrationBuilder.InsertData(
                table: "LaptopBrands",
                columns: new[] { "BrandId", "BrandName" },
                values: new object[,]
                {
                    { 1, "Dell" },
                    { 2, "Toshiba" },
                    { 3, "HP" }
                });

            migrationBuilder.InsertData(
                table: "LaptopConfigurationItems",
                columns: new[] { "ConfigurationItemId", "ItemName" },
                values: new object[,]
                {
                    { 1, "Ram" },
                    { 2, "HDD" },
                    { 3, "Colour" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ConfigurationCosts",
                keyColumn: "ConfigurationCostId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ConfigurationCosts",
                keyColumn: "ConfigurationCostId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ConfigurationCosts",
                keyColumn: "ConfigurationCostId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ConfigurationCosts",
                keyColumn: "ConfigurationCostId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ConfigurationCosts",
                keyColumn: "ConfigurationCostId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ConfigurationCosts",
                keyColumn: "ConfigurationCostId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LaptopBrands",
                keyColumn: "BrandId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LaptopBrands",
                keyColumn: "BrandId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LaptopBrands",
                keyColumn: "BrandId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LaptopConfigurationItems",
                keyColumn: "ConfigurationItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LaptopConfigurationItems",
                keyColumn: "ConfigurationItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LaptopConfigurationItems",
                keyColumn: "ConfigurationItemId",
                keyValue: 3);
        }
    }
}
