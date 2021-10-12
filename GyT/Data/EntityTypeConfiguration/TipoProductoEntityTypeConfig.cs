using GyT.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace GyT.Data.EntityTypeConfiguration
{
    internal class TipoProductoEntityTypeConfig : IEntityTypeConfiguration<TipoProducto>
    {
        public void Configure(EntityTypeBuilder<TipoProducto> builder)
        {
            builder.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            builder.Property<DateTime>("FechaCreacion")
                .HasColumnType("datetime2");

            builder.Property<string>("Nombre")
                .HasColumnType("nvarchar(max)");

            builder.HasKey("Id");

            builder.ToTable("TipoProducto");
        }
    }
}
