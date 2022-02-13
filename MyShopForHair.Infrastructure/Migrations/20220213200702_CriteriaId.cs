using Microsoft.EntityFrameworkCore.Migrations;

namespace MyShopForHair.Infrastructure.Migrations
{
    public partial class CriteriaId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CriteriaId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CriteriaId",
                table: "Products",
                column: "CriteriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Criterias_CriteriaId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CriteriaId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CriteriaId",
                table: "Products");
        }
    }
}
