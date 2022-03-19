using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPIWithDocker.Migrations
{
    public partial class initialmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Weathers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TemperatureC = table.Column<int>(type: "int", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weathers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Weathers",
                columns: new[] { "Id", "Date", "Summary", "TemperatureC" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 19, 11, 41, 16, 543, DateTimeKind.Local).AddTicks(5643), "Chilly", 50 },
                    { 2, new DateTime(2022, 3, 20, 11, 41, 16, 543, DateTimeKind.Local).AddTicks(6565), "Sweltering", 39 },
                    { 3, new DateTime(2022, 3, 21, 11, 41, 16, 543, DateTimeKind.Local).AddTicks(6574), "Warm", 34 },
                    { 4, new DateTime(2022, 3, 22, 11, 41, 16, 543, DateTimeKind.Local).AddTicks(6575), "Scorching", 51 },
                    { 5, new DateTime(2022, 3, 23, 11, 41, 16, 543, DateTimeKind.Local).AddTicks(6576), "Balmy", 11 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weathers");
        }
    }
}
