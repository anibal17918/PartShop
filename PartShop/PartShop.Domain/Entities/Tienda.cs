namespace PartShop.Domain.Entities
{
    public class Tienda : BaseEntity
    {
        public int IdTienda { get; set; }
        public string? Rnc { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }

        public virtual ICollection<Compra> Compras { get; set; } = new HashSet<Compra>();
        public virtual ICollection<ProductoTienda> ProductoTienda { get; set; } = new HashSet<ProductoTienda>();
        public virtual ICollection<Usuario> Usuarios { get; set; } = new HashSet<Usuario>();
        public virtual ICollection<Venta> Venta { get; set; } = new HashSet<Venta>();
    }
}
