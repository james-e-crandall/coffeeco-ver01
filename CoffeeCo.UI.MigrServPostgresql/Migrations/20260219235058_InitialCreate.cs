using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoffeeCo.UI.MigrServPostgresql.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StatePossessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Abbreviation = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatePossessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StateId = table.Column<int>(type: "integer", nullable: false),
                    County = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    StreetName = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    Add_Number = table.Column<long>(type: "bigint", nullable: false),
                    Zip_Code = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: true),
                    Plus_4 = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: true),
                    NationalAddressId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_StatePossessions_StateId",
                        column: x => x.StateId,
                        principalTable: "StatePossessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NationalAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Inc_Muni = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Uninc_Comm = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Nbrhd_Comm = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Post_Comm = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    Bulk_Zip = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: true),
                    Bulk_Plus4 = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: true),
                    StN_PreMod = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    StN_PreDir = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    StN_PreTyp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    StN_PreSep = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    StN_PosTyp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    StN_PosDir = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    StN_PosMod = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    AddNum_Pre = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    AddNum_Suf = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    LandmkPart = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    LandmkName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    Building = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: true),
                    Floor = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: true),
                    Unit = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: true),
                    Room = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: true),
                    Addtl_Loc = table.Column<string>(type: "character varying(225)", maxLength: 225, nullable: true),
                    Milepost = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Long = table.Column<float>(type: "real", nullable: false),
                    Lat = table.Column<float>(type: "real", nullable: false),
                    NatGrid_Coord = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    GUID = table.Column<Guid>(type: "uuid", nullable: false),
                    Addr_Type = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Placement = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    Source = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: false),
                    AddAuth = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: true),
                    UniqWithin = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Effective = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Expired = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    AddressId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationalAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NationalAddresses_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "StatePossessions",
                columns: new[] { "Id", "Abbreviation", "Value" },
                values: new object[,]
                {
                    { 1, "AL", "Alabama" },
                    { 2, "AK", "Alaska" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_StateId",
                table: "Address",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_NationalAddresses_AddressId",
                table: "NationalAddresses",
                column: "AddressId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NationalAddresses");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "StatePossessions");
        }
    }
}
