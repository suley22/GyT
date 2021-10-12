using GyT.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace GyT.Data.EntityTypeConfiguration
{
    internal class ProductoEntityTypeConfig : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            builder.Property<int>("Cantidad")
                .HasColumnType("int");

            builder.Property<decimal>("Costo")
                .HasColumnType("decimal(18,2)");

            builder.Property<DateTime>("FechaCreacion")
                .HasColumnType("datetime2");

            builder.Property<string>("IdTipoProducto")
                .HasColumnType("nvarchar(max)");

            builder.Property<string>("Nombre")
                .HasColumnType("nvarchar(max)");

            builder.Property<decimal>("PrecioVenta")
                .HasColumnType("decimal(18,2)");

            builder.Property<decimal>("PrecioVentaPack")
                .HasColumnType("decimal(18,2)");

            builder.HasKey("Id");

            builder.ToTable("Producto");
        }
    }
}
