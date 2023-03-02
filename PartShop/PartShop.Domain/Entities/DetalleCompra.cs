namespace PartShop.Domain.Entities
{
    public class DetalleCompra : BaseEntity
    {
        public int IdDetalleCompra { get; set; }
        public int? IdCompra { get; set; }
        public int? IdProducto { get; set; }
        public double? Cantidad { get; set; }
        public double? PrecioUnitarioCompra { get; set; }
        public double? PrecioUnitarioVenta { get; set; }
        public double? TotalCosto { get; set; }

        public virtual Compra? IdCompraNavigation { get; set; }
        public virtual Producto? IdProductoNavigation { get; set; }
    }
}
