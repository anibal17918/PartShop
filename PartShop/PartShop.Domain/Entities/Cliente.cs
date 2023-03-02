namespace PartShop.Domain.Entities
{
    public class Cliente : BaseEntity
    {
        public int IdCliente { get; set; }
        public string? TipoDocumento { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }

        public virtual ICollection<Venta> Venta { get; set; } = new HashSet<Venta>();
    }
}
