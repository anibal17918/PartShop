namespace PartShop.Domain.Entities
{
    public class Categoria : BaseEntity
    {
        public int IdCategoria { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Producto> Productos { get; set; } = new HashSet<Producto>();
    }
}
