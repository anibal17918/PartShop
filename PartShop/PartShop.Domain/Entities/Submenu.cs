namespace PartShop.Domain.Entities
{
    public class Submenu : BaseEntity
    {
        public int IdSubMenu { get; set; }
        public int? IdMenu { get; set; }
        public string? Nombre { get; set; }
        public string? NombreFormulario { get; set; }

        public virtual Menu? IdMenuNavigation { get; set; }
        public virtual ICollection<Permiso> Permisos { get; set; } = new HashSet<Permiso>();
    }
}
