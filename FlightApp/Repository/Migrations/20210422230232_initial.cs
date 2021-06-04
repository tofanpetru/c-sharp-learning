using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FlightDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Departure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.FlightId);
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "Departure", "Destination", "FlightDate", "FlightDuration" },
                values: new object[] { 1, "Moldova", "Viena", new DateTime(2021, 4, 23, 2, 2, 31, 228, DateTimeKind.Local).AddTicks(8990), "7h 3min" });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "Departure", "Destination", "FlightDate", "FlightDuration" },
                values: new object[] { 2, "Romania", "Argentina", new DateTime(2021, 4, 23, 2, 2, 31, 236, DateTimeKind.Local).AddTicks(7339), "5h 3min" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flights");
        }
    }
}
