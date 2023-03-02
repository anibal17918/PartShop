namespace PartShop.Domain.Entities
{
    public class Producto : BaseEntity
    {
        public int IdProducto { get; set; }
        public string? Codigo { get; set; }
        public int? ValorCodigo { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int? IdCategoria { get; set; }

        public virtual Categoria? IdCategoriaNavigation { get; set; }
        public virtual ICollection<DetalleCompra> DetalleCompras { get; set; } = new HashSet<DetalleCompra>();
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; } = new HashSet<DetalleVenta>();
        public virtual ICollection<ProductoTienda> ProductoTienda { get; set; } = new HashSet<ProductoTienda>();
    }
}
