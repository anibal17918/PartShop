using System.ComponentModel;

namespace PartShop.Domain.Entities
{
    public class Usuario : BaseEntity
    {
        public int IdUsuario { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Correo { get; set; }

        [DisplayName("Nombre de usuario")]
        public string? Usuario1 { get; set; }
        public string? Clave { get; set; }
        public int? IdTienda { get; set; }
        public int? IdRol { get; set; }

        public virtual Rol? IdRolNavigation { get; set; }
        public virtual Tienda? IdTiendaNavigation { get; set; }
        public virtual ICollection<Compra> Compras { get; set; } = new HashSet<Compra>();
        public virtual ICollection<Venta> Venta { get; set; } = new HashSet<Venta>();
    }
}
