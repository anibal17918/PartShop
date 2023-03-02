using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PartShop.Domain.Entities;

namespace PartShop.Infrastructure.EntityConfigurations
{
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasKey(e => e.IdMenu)
                .HasName("PK__MENU__4D7EA8E1DDB412F0");

            builder.Property(e => e.Activo).HasDefaultValueSql("((1))");

            builder.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.Icono)
                .HasMaxLength(60)
                .IsUnicode(false);

            builder.Property(e => e.Nombre)
                .HasMaxLength(60)
                .IsUnicode(false);
        }
    }
}
