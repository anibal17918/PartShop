using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PartShop.Domain.Entities;

namespace PartShop.Infrastructure.EntityConfigurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(e => e.IdUsuario)
                .HasName("PK__USUARIO__5B65BF97C1E56415");

            builder.Property(e => e.Activo).HasDefaultValueSql("((1))");

            builder.Property(e => e.Apellidos)
                .HasMaxLength(60)
                .IsUnicode(false);

            builder.Property(e => e.Clave)
                .HasMaxLength(60)
                .IsUnicode(false);

            builder.Property(e => e.Correo)
                .HasMaxLength(60)
                .IsUnicode(false);

            builder.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.Nombres)
                .HasMaxLength(60)
                .IsUnicode(false);

            builder.Property(e => e.Usuario1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Usuario");

            builder.HasOne(d => d.IdRolNavigation)
                .WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__USUARIO__IdRol__01142BA1");

            builder.HasOne(d => d.IdTiendaNavigation)
                .WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdTienda)
                .HasConstraintName("FK__USUARIO__IdTiend__47DBAE45");
        }
    }
}
