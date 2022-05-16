using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MikoBussDataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CiytName = table.Column<string>(type: "TEXT", nullable: true),
                    CityTesisName1 = table.Column<string>(type: "TEXT", nullable: true),
                    CityTesisName2 = table.Column<string>(type: "TEXT", nullable: true),
                    CityTesisName3 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Guzergahs",
                columns: table => new
                {
                    GuzergahId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GuzergahStart = table.Column<string>(type: "TEXT", nullable: true),
                    GuzergahEnd = table.Column<string>(type: "TEXT", nullable: true),
                    GuzergahTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    GuzargahFiyat = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guzergahs", x => x.GuzergahId);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TicketName = table.Column<string>(type: "TEXT", nullable: true),
                    TicketSurname = table.Column<string>(type: "TEXT", nullable: true),
                    TicketMail = table.Column<string>(type: "TEXT", nullable: true),
                    TicketNereden = table.Column<string>(type: "TEXT", nullable: true),
                    TicketNereye = table.Column<string>(type: "TEXT", nullable: true),
                    TicketSeatNo = table.Column<int>(type: "INTEGER", nullable: false),
                    TicketPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    GuzergahId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Tickets_Guzergahs_GuzergahId",
                        column: x => x.GuzergahId,
                        principalTable: "Guzergahs",
                        principalColumn: "GuzergahId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_GuzergahId",
                table: "Tickets",
                column: "GuzergahId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Guzergahs");
        }
    }
}
