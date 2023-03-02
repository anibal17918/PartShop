namespace PartShop.Domain.Entities
{
    public class ProductoTienda : BaseEntity
    {
        public int IdProductoTienda { get; set; }
        public int? IdProducto { get; set; }
        public int? IdTienda { get; set; }
        public double? PrecioUnidadCompra { get; set; }
        public double? PrecioUnidadVenta { get; set; }
        public long? Stock { get; set; }
        public bool? Iniciado { get; set; }

        public virtual Producto? IdProductoNavigation { get; set; }
        public virtual Tienda? IdTiendaNavigation { get; set; }
    }
}
