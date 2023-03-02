namespace PartShop.Domain.Entities
{
    public class Proveedor : BaseEntity
    {
        public int IdProveedor { get; set; }
        public string? Rnc { get; set; }
        public string? RazonSocial { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public string? Direccion { get; set; }

        public virtual ICollection<Compra> Compras { get; set; } = new HashSet<Compra>();
    }
}
