using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PartShop.Domain.Entities
{
    public class Producto : BaseEntity
    {
        public int IdProducto { get; set; }
        public string? Codigo { get; set; }

        [DisplayName("Precio")]
        [DisplayFormat(DataFormatString = "{0:#,##0.00}")]
        public int? ValorCodigo { get; set; }
        public string? Nombre { get; set; }

        [DisplayName("Descripción")]
        public string? Descripcion { get; set; }

        [DisplayName("Cantidad disponible")]
        public int Stock { get; set; }

        [DisplayName("Año")]
        public int Ano { get; set; }

        [DisplayName("Categoría")]
        public int? IdCategoria { get; set; }

        [DisplayName("Marca")]
        public int? IdMarca { get; set; }

        [DisplayName("Modelo")]
        public int? IdModelo { get; set; }

        public virtual Categoria? IdCategoriaNavigation { get; set; }
        public virtual ICollection<DetalleCompra> DetalleCompras { get; set; } = new HashSet<DetalleCompra>();
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; } = new HashSet<DetalleVenta>();
        public virtual ICollection<ProductoTienda> ProductoTienda { get; set; } = new HashSet<ProductoTienda>();
    }
}
