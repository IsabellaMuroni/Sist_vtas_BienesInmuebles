// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sist_vtas_bienesInmuebles.Context;

#nullable disable

namespace sistvtasbienesInmuebles.Migrations
{
    [DbContext(typeof(InmuebleContext))]
    [Migration("20230111223729_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("sist_vtas_bienesInmuebles.Models.Cliente", b =>
                {
                    b.Property<int>("Id_cliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_cliente"));

                    b.Property<string>("Correo_cliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dir_cliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_cliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono_cliente")
                        .HasColumnType("int");

                    b.HasKey("Id_cliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("sist_vtas_bienesInmuebles.Models.Condicion", b =>
                {
                    b.Property<int>("Id_condicion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_condicion"));

                    b.Property<string>("Desc_condicion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_condicion");

                    b.ToTable("Condiciones");
                });

            modelBuilder.Entity("sist_vtas_bienesInmuebles.Models.Forma_Pago", b =>
                {
                    b.Property<int>("Id_forma_pago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_forma_pago"));

                    b.Property<string>("Desc_forma_pago")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_forma_pago");

                    b.ToTable("Forma_Pago");
                });

            modelBuilder.Entity("sist_vtas_bienesInmuebles.Models.Inmueble", b =>
                {
                    b.Property<int>("Id_Inmueble")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Inmueble"));

                    b.Property<double>("Costo_inmueble")
                        .HasColumnType("float");

                    b.Property<string>("Desc_inmueble")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_tipo_inmueble")
                        .HasColumnType("int");

                    b.Property<string>("Ubic_inmueble")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Inmueble");

                    b.ToTable("Inmuebles");
                });

            modelBuilder.Entity("sist_vtas_bienesInmuebles.Models.Tipo_Inmueble", b =>
                {
                    b.Property<int>("Id_tipo_inmueble")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_tipo_inmueble"));

                    b.Property<string>("Desc_inmueble")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_tipo_inmueble");

                    b.ToTable("Tipo_Inmuebles");
                });

            modelBuilder.Entity("sist_vtas_bienesInmuebles.Models.Venta", b =>
                {
                    b.Property<int>("Id_venta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_venta"));

                    b.Property<string>("Desc_venta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_venta")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_cliente")
                        .HasColumnType("int");

                    b.Property<int>("Id_condicion")
                        .HasColumnType("int");

                    b.Property<int>("Id_forma_pago")
                        .HasColumnType("int");

                    b.Property<int>("Id_inmueble")
                        .HasColumnType("int");

                    b.Property<double>("Total_general")
                        .HasColumnType("float");

                    b.Property<double>("Total_iva")
                        .HasColumnType("float");

                    b.Property<double>("Total_venta")
                        .HasColumnType("float");

                    b.HasKey("Id_venta");

                    b.ToTable("Ventas");
                });
#pragma warning restore 612, 618
        }
    }
}
