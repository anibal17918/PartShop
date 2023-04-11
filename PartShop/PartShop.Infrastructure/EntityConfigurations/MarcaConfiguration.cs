using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PartShop.Domain.Entities;

namespace PartShop.Infrastructure.EntityConfigurations
{
    public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Activo).HasDefaultValueSql("((1))");

            builder.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.HasMany(d => d.Modelos)
                .WithOne(p => p.Marca)
                .HasForeignKey(d => d.IdMarca);
        }
    }
}
