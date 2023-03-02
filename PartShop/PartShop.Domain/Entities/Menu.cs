namespace PartShop.Domain.Entities
{
    public class Menu : BaseEntity
    {
        public int IdMenu { get; set; }
        public string? Nombre { get; set; }
        public string? Icono { get; set; }

        public virtual ICollection<Submenu> Submenus { get; set; } = new HashSet<Submenu>();
    }
}
