using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppCarLog.Data.Migrations
{
    /// <inheritdoc />
    public partial class Veiculos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Placa = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    Fabricante = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AnoFabricacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Km = table.Column<int>(type: "int", nullable: false),
                    Base = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
