using GyT.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace GyT.Data.EntityTypeConfiguration
{
    internal class VentaEntityTypeConfig : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            builder.Property<int>("Cantidad")
                .HasColumnType("int");

            builder.Property<DateTime>("FechaCreacion")
                .HasColumnType("datetime2");

            builder.Property<int>("IdProducto")
                .HasColumnType("int");

            builder.Property<bool>("Pack")
                .HasColumnType("bit");

            builder.Property<decimal>("PrecioActual")
                .HasColumnType("decimal(18,2)");

            builder.Property<decimal>("PrecioVenta")
                .HasColumnType("decimal(18,2)");

            builder.Property<bool>("Promo")
                .HasColumnType("bit");

            builder.HasKey("Id");

            builder.ToTable("Venta");
        }
    }
}
