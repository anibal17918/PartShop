using PartShop.Domain.Entities;
using PartShop.Domain.Repositories;

namespace PartShop.Infrastructure.Repositories
{
    public class TiendaRepository : BaseRepository<Tienda>, ITiendaRepository
    {
        public TiendaRepository(PartShopDbContext context) : base(context)
        {
        }
    }
}
