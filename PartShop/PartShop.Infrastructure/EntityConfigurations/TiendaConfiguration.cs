using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PartShop.Domain.Entities;

namespace PartShop.Infrastructure.EntityConfigurations
{
    public class TiendaConfiguration : IEntityTypeConfiguration<Tienda>
    {
        public void Configure(EntityTypeBuilder<Tienda> builder)
        {
            builder.HasKey(e => e.IdTienda)
                .HasName("PK__TIENDA__5A1EB96B8757EB7F");

            builder.Property(e => e.Activo).HasDefaultValueSql("((1))");

            builder.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.Nombre)
                .HasMaxLength(60)
                .IsUnicode(false);

            builder.Property(e => e.Rnc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RNC");

            builder.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
