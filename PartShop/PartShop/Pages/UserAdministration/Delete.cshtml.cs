using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace PartShop.Pages.UserAdministration;

public class DeleteUserModel : PageModel
{
    private readonly PartShop.Infrastructure.PartShopDbContext _context;

    public DeleteUserModel(PartShop.Infrastructure.PartShopDbContext context)
    {
        _context = context;
    }

    [BindProperty]
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

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id == null || _context.Usuario == null)
        {
            return NotFound();
        }
        var usuario = await _context.Usuario.FindAsync(id);

        if (usuario != null)
        {
            Usuario = usuario;
            _context.Usuario.Remove(usuario);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
