using Microsoft.EntityFrameworkCore.Migrations;

namespace MyShopForHair.Infrastructure.Migrations
{
    public partial class Fix_Relationship_Between_Criteria_and_Group : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Criterias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Criterias_GroupId",
                table: "Criterias",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Criterias_Group_GroupId",
                table: "Criterias",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Criterias_Group_GroupId",
                table: "Criterias");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropIndex(
                name: "IX_Criterias_GroupId",
                table: "Criterias");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Criterias");
        }
    }
}
