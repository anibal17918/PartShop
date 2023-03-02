namespace PartShop.Domain.Entities
{
    public class Permiso : BaseEntity
    {
        public int IdPermisos { get; set; }
        public int? IdRol { get; set; }
        public int? IdSubMenu { get; set; }

        public virtual Rol? IdRolNavigation { get; set; }
        public virtual Submenu? IdSubMenuNavigation { get; set; }
    }
}
