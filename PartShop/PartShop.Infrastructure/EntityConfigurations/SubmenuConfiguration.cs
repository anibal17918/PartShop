using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PartShop.Domain.Entities;

namespace PartShop.Infrastructure.EntityConfigurations
{
    public class SubmenuConfiguration : IEntityTypeConfiguration<Submenu>
    {
        public void Configure(EntityTypeBuilder<Submenu> builder)
        {
            builder.HasKey(e => e.IdSubMenu)
                .HasName("PK__SUBMENU__CFDCE01ADBEDBD61");

            builder.Property(e => e.Activo).HasDefaultValueSql("((1))");

            builder.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.Nombre)
                .HasMaxLength(60)
                .IsUnicode(false);

            builder.Property(e => e.NombreFormulario)
                .HasMaxLength(60)
                .IsUnicode(false);

            builder.HasOne(d => d.IdMenuNavigation)
                .WithMany(p => p.Submenus)
                .HasForeignKey(d => d.IdMenu)
                .HasConstraintName("FK__SUBMENU__IdMenu__00200768");
        }
    }
}
