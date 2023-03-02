using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PartShop.Domain.Entities;

namespace PartShop.Infrastructure.EntityConfigurations
{
    public class VentaConfiguration : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.HasKey(e => e.IdVenta)
                .HasName("PK__VENTA__BC1240BD0E9CC8BB");

            builder.Property(e => e.Activo).HasDefaultValueSql("((1))");

            builder.Property(e => e.Codigo)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.HasOne(d => d.IdClienteNavigation)
                .WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK__VENTA__IdCliente__02FC7413");

            builder.HasOne(d => d.IdTiendaNavigation)
                .WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdTienda)
                .HasConstraintName("FK__VENTA__IdTienda__7B5B524B");

            builder.HasOne(d => d.IdUsuarioNavigation)
                .WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__VENTA__IdUsuario__04E4BC85");
        }
    }
}
