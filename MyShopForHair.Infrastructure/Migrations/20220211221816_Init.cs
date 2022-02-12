using Microsoft.EntityFrameworkCore.Migrations;

namespace MyShopForHair.Infrastructure.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CriteriaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Login = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nchar(128)", fixedLength: true, maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Criterias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criterias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criterias_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_Members_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Members_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    RolesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.RolesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_RoleUser_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Davines" },
                    { 15, "Moroccanoil" },
                    { 14, "R+CO" },
                    { 13, "Kapous" },
                    { 12, "Batiste" },
                    { 10, "Matrix" },
                    { 9, "ORIBE" },
                    { 11, "Rated Green" },
                    { 7, "Loreal Professional" },
                    { 6, "Kerastase" },
                    { 5, "Global Keratin" },
                    { 4, "TIGI" },
                    { 3, "CHI" },
                    { 2, "Lador" },
                    { 8, "Olaplex" }
                });

            migrationBuilder.InsertData(
                table: "Criterias",
                columns: new[] { "Id", "Name", "ProductsId" },
                values: new object[,]
                {
                    { 9, "Для блондинок", null },
                    { 13, "Жирные", null },
                    { 12, "Сухие", null },
                    { 11, "Пористые", null },
                    { 10, "Вьющиеся", null },
                    { 8, "Ломкие", null },
                    { 6, "Окрашенные", null },
                    { 5, "Комбинированная", null },
                    { 4, "Жирная", null },
                    { 3, "Нормальная", null },
                    { 2, "Чувствительная", null },
                    { 1, "Сухая", null },
                    { 7, "Поврежденные", null }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "CriteriaID", "Name" },
                values: new object[,]
                {
                    { 4, 11, "Пористые волосы" },
                    { 1, 7, "Поврежденные и окрашенные волосы" },
                    { 2, 10, "Вьющиеся волосы" },
                    { 3, 12, "Сухие волосы" },
                    { 5, 13, "Жирные волосы" },
                    { 6, 1, "Сухая кожа головы" },
                    { 7, 2, "Чувствительная кожа головы" },
                    { 8, 3, "Нормальная кожа головы" },
                    { 9, 4, "Жирная кожа головы" },
                    { 10, 5, "Комбинированная кожа головы" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "manager" },
                    { 1, "admin" },
                    { 3, "visitor" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Criterias_ProductsId",
                table: "Criterias",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_RoleId",
                table: "Members",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_UsersId",
                table: "RoleUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Criterias");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
