namespace PartShop.Domain.Entities
{
    public class Rol : BaseEntity
    {
        public int IdRol { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Permiso> Permisos { get; set; } = new HashSet<Permiso>();
        public virtual ICollection<Usuario> Usuarios { get; set; } = new HashSet<Usuario>();
    }
}
