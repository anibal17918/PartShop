using Microsoft.EntityFrameworkCore;
using PartShop.Domain.Entities;
using PartShop.Domain.Models;
using PartShop.Domain.Repositories;

namespace PartShop.Infrastructure.Repositories
{
    public class ProductoRepository : BaseRepository<Producto>, IProductoRepository
    {
        public ProductoRepository(PartShopDbContext context) : base(context)
        {
        }

        public Task<List<ProductoModel>> GetAllByMarcaModelo(int idMarca, int idModelo)
        {
            return Context.Producto
                .Where(p => p.IdMarca == idMarca && p.IdModelo == idModelo && p.Stock > 0)
                .Select(p => new ProductoModel
                {
                    IdProducto = p.IdProducto,
                    Nombre = p.Nombre,
                    Descripcion = p.Descripcion,
                    Precio = p.ValorCodigo.GetValueOrDefault(),
                    Stock = p.Stock,
                    Ano = p.Ano
                }).ToListAsync();
        }

        public async Task<bool> BuyProducto(int idProducto)
        {
            var producto = await Context.Producto.FirstOrDefaultAsync(p => p.IdProducto == idProducto);

            if (producto is null)
            {
                return false;
            }

            producto.Stock -= 1;

            Context.Producto.Update(producto);

            await Context.SaveChangesAsync();

            return true;
        }
    }
}
