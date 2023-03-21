using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace PartShop.Pages.Producto
{
    public class IndexModel : PageModel
    {
        private readonly PartShop.Infrastructure.PartShopDbContext _context;

        public IndexModel(PartShop.Infrastructure.PartShopDbContext context)
        {
            _context = context;
        }

        public IList<Domain.Entities.Producto> Producto { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Producto != null)
            {
                Producto = await _context.Producto
                .Include(p => p.IdCategoriaNavigation).ToListAsync();
            }
        }
    }
}
