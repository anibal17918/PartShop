using Microsoft.EntityFrameworkCore;
using PartShop.Domain.Entities;
using PartShop.Infrastructure.EntityConfigurations;

namespace PartShop.Infrastructure
{
    public class PartShopDbContext : DbContext
    {
        public PartShopDbContext(DbContextOptions<PartShopDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; } = null!;
        public virtual DbSet<Cliente> Cliente { get; set; } = null!;
        public virtual DbSet<Compra> Compra { get; set; } = null!;
        public virtual DbSet<DetalleCompra> DetalleCompra { get; set; } = null!;
        public virtual DbSet<DetalleVenta> DetalleVenta { get; set; } = null!;
        public virtual DbSet<Menu> Menu { get; set; } = null!;
        public virtual DbSet<Permiso> Permiso { get; set; } = null!;
        public virtual DbSet<Producto> Producto { get; set; } = null!;
        public virtual DbSet<ProductoTienda> ProductoTienda { get; set; } = null!;
        public virtual DbSet<Proveedor> Proveedor { get; set; } = null!;
        public virtual DbSet<Rol> Rol { get; set; } = null!;
        public virtual DbSet<Submenu> Submenu { get; set; } = null!;
        public virtual DbSet<Tienda> Tienda { get; set; } = null!;
        public virtual DbSet<Usuario> Usuario { get; set; } = null!;
        public virtual DbSet<Venta> Venta { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UsuarioConfiguration).Assembly);
        }
    }
}
