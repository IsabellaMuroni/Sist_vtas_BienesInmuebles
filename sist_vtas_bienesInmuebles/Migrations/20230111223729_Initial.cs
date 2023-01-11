using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistvtasbienesInmuebles.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Idcliente = table.Column<int>(name: "Id_cliente", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombrecliente = table.Column<string>(name: "Nombre_cliente", type: "nvarchar(max)", nullable: false),
                    Dircliente = table.Column<string>(name: "Dir_cliente", type: "nvarchar(max)", nullable: false),
                    Correocliente = table.Column<string>(name: "Correo_cliente", type: "nvarchar(max)", nullable: false),
                    Telefonocliente = table.Column<int>(name: "Telefono_cliente", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Idcliente);
                });

            migrationBuilder.CreateTable(
                name: "Condiciones",
                columns: table => new
                {
                    Idcondicion = table.Column<int>(name: "Id_condicion", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Desccondicion = table.Column<string>(name: "Desc_condicion", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condiciones", x => x.Idcondicion);
                });

            migrationBuilder.CreateTable(
                name: "Forma_Pago",
                columns: table => new
                {
                    Idformapago = table.Column<int>(name: "Id_forma_pago", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descformapago = table.Column<string>(name: "Desc_forma_pago", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forma_Pago", x => x.Idformapago);
                });

            migrationBuilder.CreateTable(
                name: "Inmuebles",
                columns: table => new
                {
                    IdInmueble = table.Column<int>(name: "Id_Inmueble", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idtipoinmueble = table.Column<int>(name: "Id_tipo_inmueble", type: "int", nullable: false),
                    Descinmueble = table.Column<string>(name: "Desc_inmueble", type: "nvarchar(max)", nullable: false),
                    Ubicinmueble = table.Column<string>(name: "Ubic_inmueble", type: "nvarchar(max)", nullable: false),
                    Costoinmueble = table.Column<double>(name: "Costo_inmueble", type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inmuebles", x => x.IdInmueble);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Inmuebles",
                columns: table => new
                {
                    Idtipoinmueble = table.Column<int>(name: "Id_tipo_inmueble", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descinmueble = table.Column<string>(name: "Desc_inmueble", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Inmuebles", x => x.Idtipoinmueble);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    Idventa = table.Column<int>(name: "Id_venta", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idinmueble = table.Column<int>(name: "Id_inmueble", type: "int", nullable: false),
                    Idcliente = table.Column<int>(name: "Id_cliente", type: "int", nullable: false),
                    Idcondicion = table.Column<int>(name: "Id_condicion", type: "int", nullable: false),
                    Idformapago = table.Column<int>(name: "Id_forma_pago", type: "int", nullable: false),
                    Descventa = table.Column<string>(name: "Desc_venta", type: "nvarchar(max)", nullable: false),
                    Totalventa = table.Column<double>(name: "Total_venta", type: "float", nullable: false),
                    Totaliva = table.Column<double>(name: "Total_iva", type: "float", nullable: false),
                    Totalgeneral = table.Column<double>(name: "Total_general", type: "float", nullable: false),
                    Fechaventa = table.Column<DateTime>(name: "Fecha_venta", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.Idventa);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Condiciones");

            migrationBuilder.DropTable(
                name: "Forma_Pago");

            migrationBuilder.DropTable(
                name: "Inmuebles");

            migrationBuilder.DropTable(
                name: "Tipo_Inmuebles");

            migrationBuilder.DropTable(
                name: "Ventas");
        }
    }
}
