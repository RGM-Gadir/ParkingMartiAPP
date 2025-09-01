using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkingMartiAPP.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    idVehiculo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipoVehiculo = table.Column<int>(type: "int", nullable: false),
                    ClienteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.idVehiculo);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_ClientesidCliente",
                table: "Vehiculos",
                column: "ClienteID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
          
            migrationBuilder.DropTable(
                name: "Vehiculos");

        }
    }
}
