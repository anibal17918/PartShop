using PartShop.Domain.Entities;
using PartShop.Domain.Models;

namespace PartShop.Domain.Repositories
{
    public interface IProductoRepository : IBaseRepository<Producto>
    {
        Task<List<ProductoModel>> GetAllByMarcaModelo(int idMarca, int idModelo);
        Task<bool> BuyProducto(int idProducto);
    }
}
