using PartShop.Domain.Entities;
using PartShop.Domain.Repositories;

namespace PartShop.Infrastructure.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(PartShopDbContext context) : base(context)
        {
        }
    }
}