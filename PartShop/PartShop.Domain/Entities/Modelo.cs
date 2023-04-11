namespace PartShop.Domain.Entities
{
    public class Modelo : BaseEntity
    {
        public int Id { get; set; }
        public int IdMarca { get; set; }
        public string? Descripcion { get; set; }

        public virtual Marca? Marca { get; set; }
    }
}
