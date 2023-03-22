using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace PartShop.Pages.Registro_usuarios
{
    public class IndexModel : PageModel
    {
        private readonly PartShop.Infrastructure.PartShopDbContext _context;

        public IndexModel(PartShop.Infrastructure.PartShopDbContext context)
        {
            _context = context;
        }

        public IList<Domain.Entities.Usuario> Usuarios { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Usuario != null)
            {
                Usuarios = await _context.Usuario
                .Include(p => p.IdRolNavigation).ToListAsync();
            }
        }
    }
}