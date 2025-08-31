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
                name: "LineasFactura",
                columns: table => new
                {
                    idLinea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idFactura = table.Column<int>(type: "int", nullable: false),
                    idLineaEnFactura = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    precio1 = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    cantidad1 = table.Column<int>(type: "int", nullable: false),
                    IVA = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    BaseImponible = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Retencion = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    ImporteTotal = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineasFactura", x => x.idLinea);
                });

            migrationBuilder.CreateTable(
                name: "LineasProforma",
                columns: table => new
                {
                    idLinea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idProforma = table.Column<int>(type: "int", nullable: false),
                    idLineaEnProforma = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    precio1 = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    cantidad1 = table.Column<int>(type: "int", nullable: false),
                    IVA = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    BaseImponible = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Retencion = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    ImporteTotal = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineasProforma", x => x.idLinea);
                });

            migrationBuilder.CreateTable(
                name: "Proformas",
                columns: table => new
                {
                    idProforma = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroDeProforma = table.Column<int>(type: "int", nullable: false),
                    NumeroDeFactura = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IVA = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    BaseImponible = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Retencion = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    ImporteTotal = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    MetodoDePago = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    precio1 = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    precio2 = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    precio3 = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    cantidad1 = table.Column<int>(type: "int", nullable: false),
                    cantidad2 = table.Column<int>(type: "int", nullable: false),
                    cantidad3 = table.Column<int>(type: "int", nullable: false),
                    Descripcion2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuiereMatriculas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClienteID = table.Column<int>(type: "int", nullable: true),
                    ProveedorID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proformas", x => x.idProforma);
                });

            migrationBuilder.CreateTable(
                name: "Trabajadores",
                columns: table => new
                {
                    idTrabajador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreYApellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CIF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poblacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diasTrabajados = table.Column<int>(type: "int", nullable: false),
                    horasTrabajadas = table.Column<int>(type: "int", nullable: false),
                    vacaciones = table.Column<int>(type: "int", nullable: false),
                    numeroSeguridasSocial = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trabajadores", x => x.idTrabajador);
                });

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
                    table.ForeignKey(
                        name: "FK_Vehiculos_Clientes_ClientesidCliente",
                        column: x => x.idVehiculo,
                        principalTable: "Clientes",
                        principalColumn: "idCliente");
                });

           
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
    
            migrationBuilder.DropTable(
                name: "LineasFactura");

            migrationBuilder.DropTable(
                name: "LineasProforma");

            migrationBuilder.DropTable(
                name: "Proformas");

            migrationBuilder.DropTable(
                name: "Trabajadores");

            migrationBuilder.DropTable(
                name: "Vehiculos");

        }
    }
}
