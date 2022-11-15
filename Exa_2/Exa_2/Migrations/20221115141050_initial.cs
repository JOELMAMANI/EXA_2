using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exa_2.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "floors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Plant_Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Plant_family = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Plant_Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Plant_Type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Plant_years = table.Column<decimal>(type: "decimal(18,2)", maxLength: 8, nullable: true),
                    Plant_cost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Planting_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Planting_amount = table.Column<double>(type: "float", nullable: true),
                    Plant_sold = table.Column<bool>(type: "bit", nullable: true),
                    Medicinal_plants = table.Column<bool>(type: "bit", nullable: false),
                    Indoor_plants = table.Column<bool>(type: "bit", nullable: false),
                    IsActivate = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_floors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "irrigations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Plantation_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plantation_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plantation_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type_land = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plantation_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Watering_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Planting_amount = table.Column<double>(type: "float", nullable: true),
                    IsActivate = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_irrigations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "floors");

            migrationBuilder.DropTable(
                name: "irrigations");
        }
    }
}
