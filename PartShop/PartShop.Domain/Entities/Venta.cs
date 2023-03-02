namespace PartShop.Domain.Entities
{
    public class Venta : BaseEntity
    {
        public int IdVenta { get; set; }
        public string? Codigo { get; set; }
        public int? ValorCodigo { get; set; }
        public int? IdTienda { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdCliente { get; set; }
        public string? TipoDocumento { get; set; }
        public int? CantidadProducto { get; set; }
        public int? CantidadTotal { get; set; }
        public double? TotalCosto { get; set; }
        public double? ImporteRecibido { get; set; }
        public double? ImporteCambio { get; set; }

        public virtual Cliente? IdClienteNavigation { get; set; }
        public virtual Tienda? IdTiendaNavigation { get; set; }
        public virtual Usuario? IdUsuarioNavigation { get; set; }
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; } = new HashSet<DetalleVenta>();
    }
}
