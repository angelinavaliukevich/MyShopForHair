using Microsoft.EntityFrameworkCore.Migrations;

namespace MyShopForHair.Infrastructure.Migrations
{
    public partial class Fix_GroupId_name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Criterias_Group_GroupId",
                table: "Criterias");

            migrationBuilder.DropColumn(
                name: "IdGroup",
                table: "Criterias");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "Criterias",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Criterias_Group_GroupId",
                table: "Criterias",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Criterias_Group_GroupId",
                table: "Criterias");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "Criterias",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdGroup",
                table: "Criterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Criterias_Group_GroupId",
                table: "Criterias",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
