using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PartShop.Infrastructure.EntityConfigurations;
using PartShop.Domain.Entities;
namespace PartShop.Pages.UserAdministration;

public class IndexModel : PageModel
{
    private readonly PartShop.Infrastructure.PartShopDbContext _context;

    public IndexModel(PartShop.Infrastructure.PartShopDbContext context)
    {
        _context = context;
    }

    public IList<Domain.Entities.Usuario> Usuario { get; set; } = default!;

    public async Task OnGetAsync()
    {
        if (_context.Usuario != null)
        {
            Usuario = await _context.Usuario
            .Include(p => p.IdRolNavigation).ToListAsync();
        }
    }
}
