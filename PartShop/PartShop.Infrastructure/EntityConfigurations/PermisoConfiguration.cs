using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PartShop.Domain.Entities;

namespace PartShop.Infrastructure.EntityConfigurations
{
    public class PermisoConfiguration : IEntityTypeConfiguration<Permiso>
    {
        public void Configure(EntityTypeBuilder<Permiso> builder)
        {
            builder.HasKey(e => e.IdPermisos)
                .HasName("PK__PERMISOS__CE7ED38D68B1795B");

            builder.Property(e => e.Activo).HasDefaultValueSql("((1))");

            builder.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.HasOne(d => d.IdRolNavigation)
                .WithMany(p => p.Permisos)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__PERMISOS__IdRol__7B5B524B");

            builder.HasOne(d => d.IdSubMenuNavigation)
                .WithMany(p => p.Permisos)
                .HasForeignKey(d => d.IdSubMenu)
                .HasConstraintName("FK__PERMISOS__IdSubM__7C4F7684");
        }
    }
}
