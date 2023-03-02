namespace PartShop.Domain.Entities
{
    public class DetalleVenta : BaseEntity
    {
        public int IdDetalleVenta { get; set; }
        public int? IdVenta { get; set; }
        public int? IdProducto { get; set; }
        public int? Cantidad { get; set; }
        public double? PrecioUnidad { get; set; }
        public double? ImporteTotal { get; set; }

        public virtual Producto? IdProductoNavigation { get; set; }
        public virtual Venta? IdVentaNavigation { get; set; }
    }
}
