using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PartShop.Domain.Entities;

namespace PartShop.Infrastructure.EntityConfigurations
{
    public class CompraConfiguration : IEntityTypeConfiguration<Compra>
    {
        public void Configure(EntityTypeBuilder<Compra> builder)
        {
            builder.HasKey(e => e.IdCompra)
                .HasName("PK__COMPRA__0A5CDB5C65B0F13C");

            builder.Property(e => e.Activo).HasDefaultValueSql("((1))");

            builder.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.TipoComprobante)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('Boleta')");

            builder.Property(e => e.TotalCosto).HasDefaultValueSql("((0))");

            builder.HasOne(d => d.IdProveedorNavigation)
                .WithMany(p => p.Compras)
                .HasForeignKey(d => d.IdProveedor)
                .HasConstraintName("FK__COMPRA__IdProvee__74AE54BC");

            builder.HasOne(d => d.IdTiendaNavigation)
                .WithMany(p => p.Compras)
                .HasForeignKey(d => d.IdTienda)
                .HasConstraintName("FK__COMPRA__IdTienda__6B24EA82");

            builder.HasOne(d => d.IdUsuarioNavigation)
                .WithMany(p => p.Compras)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__COMPRA__IdUsuari__76969D2E");
        }
    }
}
