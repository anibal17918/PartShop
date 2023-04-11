using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PartShop.Domain.Entities;

namespace PartShop.Infrastructure.EntityConfigurations
{
    public class ModeloConfiguration : IEntityTypeConfiguration<Modelo>
    {
        public void Configure(EntityTypeBuilder<Modelo> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Activo).HasDefaultValueSql("((1))");

            builder.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.HasOne(d => d.Marca)
                .WithMany(p => p.Modelos)
                .HasForeignKey(d => d.IdMarca);
        }
    }
}
