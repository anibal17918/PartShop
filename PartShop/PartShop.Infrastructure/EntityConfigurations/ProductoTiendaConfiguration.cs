using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PartShop.Domain.Entities;

namespace PartShop.Infrastructure.EntityConfigurations
{
    public class ProductoTiendaConfiguration : IEntityTypeConfiguration<ProductoTienda>
    {
        public void Configure(EntityTypeBuilder<ProductoTienda> builder)
        {
            builder.HasKey(e => e.IdProductoTienda)
                .HasName("PK__PRODUCTO__CE9B4C832D28B20F");

            builder.Property(e => e.Activo).HasDefaultValueSql("((1))");

            builder.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.Iniciado).HasDefaultValueSql("((0))");

            builder.Property(e => e.PrecioUnidadCompra).HasDefaultValueSql("((0))");

            builder.Property(e => e.PrecioUnidadVenta).HasDefaultValueSql("((0))");

            builder.Property(e => e.Stock).HasDefaultValueSql("((0))");

            builder.HasOne(d => d.IdProductoNavigation)
                .WithMany(p => p.ProductoTienda)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("FK__PRODUCTO___IdPro__7E37BEF6");

            builder.HasOne(d => d.IdTiendaNavigation)
                .WithMany(p => p.ProductoTienda)
                .HasForeignKey(d => d.IdTienda)
                .HasConstraintName("FK__PRODUCTO___IdTie__60A75C0F");
        }
    }
}
