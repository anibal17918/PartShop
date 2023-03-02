namespace PartShop.Domain.Entities
{
    public class Compra : BaseEntity
    {
        public int IdCompra { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdProveedor { get; set; }
        public int? IdTienda { get; set; }
        public double? TotalCosto { get; set; }
        public string? TipoComprobante { get; set; }

        public virtual Proveedor? IdProveedorNavigation { get; set; }
        public virtual Tienda? IdTiendaNavigation { get; set; }
        public virtual Usuario? IdUsuarioNavigation { get; set; }
        public virtual ICollection<DetalleCompra> DetalleCompras { get; set; } = new HashSet<DetalleCompra>();
    }
}
