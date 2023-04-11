namespace PartShop.Domain.Entities
{
    public class Marca : BaseEntity
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Modelo> Modelos { get; set; } = new HashSet<Modelo>();
    }
}
