using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleComputerShopAPI.Migrations
{
    public partial class UpdateUniqueConstraintConfigCost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ConfigurationCosts_ConfigurationItemId",
                table: "ConfigurationCosts");

            migrationBuilder.CreateIndex(
                name: "IX_ConfigurationCosts_ConfigurationItemId_Option",
                table: "ConfigurationCosts",
                columns: new[] { "ConfigurationItemId", "Option" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ConfigurationCosts_ConfigurationItemId_Option",
                table: "ConfigurationCosts");

            migrationBuilder.CreateIndex(
                name: "IX_ConfigurationCosts_ConfigurationItemId",
                table: "ConfigurationCosts",
                column: "ConfigurationItemId",
                unique: true);
        }
    }
}
