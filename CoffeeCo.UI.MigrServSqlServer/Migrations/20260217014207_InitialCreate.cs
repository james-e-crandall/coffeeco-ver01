using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeCo.UI.MigrServSqlServer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HomeLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cols = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeRows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeRows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomeRows_HomeLists_HomeListId",
                        column: x => x.HomeListId,
                        principalTable: "HomeLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomeItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeRowId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomeItems_HomeRows_HomeRowId",
                        column: x => x.HomeRowId,
                        principalTable: "HomeRows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "HomeLists",
                columns: new[] { "Id", "Active", "Cols", "Created", "StartDate", "Updated" },
                values: new object[] { 1, true, 2, new DateTime(2026, 2, 17, 1, 42, 7, 515, DateTimeKind.Utc).AddTicks(5264), new DateTime(2026, 2, 17, 1, 42, 7, 515, DateTimeKind.Utc).AddTicks(5064), new DateTime(2026, 2, 17, 1, 42, 7, 515, DateTimeKind.Utc).AddTicks(5352) });

            migrationBuilder.InsertData(
                table: "HomeRows",
                columns: new[] { "Id", "HomeListId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "HomeItems",
                columns: new[] { "Id", "HomeRowId", "Text" },
                values: new object[] { 1, 1, "Hello World" });

            migrationBuilder.CreateIndex(
                name: "IX_HomeItems_HomeRowId",
                table: "HomeItems",
                column: "HomeRowId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeRows_HomeListId",
                table: "HomeRows",
                column: "HomeListId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomeItems");

            migrationBuilder.DropTable(
                name: "HomeRows");

            migrationBuilder.DropTable(
                name: "HomeLists");
        }
    }
}
