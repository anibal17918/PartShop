using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace PartShop.Pages.UserAdministration;

public class DetailsUserModel : PageModel
{
    private readonly PartShop.Infrastructure.PartShopDbContext _context;

    public DetailsUserModel(PartShop.Infrastructure.PartShopDbContext context)
    {
        _context = context;
    }

  public Domain.Entities.Usuario Usuario { get; set; } = default!; 

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null || _context.Usuario == null)
        {
            return NotFound();
        }

        var usuario = await _context.Usuario.FirstOrDefaultAsync(m => m.IdUsuario == id);
        if (usuario == null)
        {
            return NotFound();
        }
        else 
        {
            Usuario = usuario;
        }
        return Page();
    }
}
