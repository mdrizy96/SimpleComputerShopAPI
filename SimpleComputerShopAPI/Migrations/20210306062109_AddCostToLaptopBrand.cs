using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleComputerShopAPI.Migrations
{
    public partial class AddCostToLaptopBrand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Cost",
                table: "LaptopBrands",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "LaptopBrands",
                keyColumn: "BrandId",
                keyValue: 1,
                column: "Cost",
                value: 34987L);

            migrationBuilder.UpdateData(
                table: "LaptopBrands",
                keyColumn: "BrandId",
                keyValue: 2,
                column: "Cost",
                value: 34567L);

            migrationBuilder.UpdateData(
                table: "LaptopBrands",
                keyColumn: "BrandId",
                keyValue: 3,
                column: "Cost",
                value: 45676L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "LaptopBrands");
        }
    }
}
