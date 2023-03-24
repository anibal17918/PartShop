using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace PartShop.Pages.UserAdministration;

public class EditUserModel : PageModel
{
    private readonly PartShop.Infrastructure.PartShopDbContext _context;

    public EditUserModel(PartShop.Infrastructure.PartShopDbContext context)
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

        var usuario =  await _context.Usuario.FirstOrDefaultAsync(m => m.IdUsuario == id);
        if (usuario == null)
        {
            return NotFound();
        }
        Usuario = usuario;
        
        ViewData["Tiendas"] = new SelectList(_context.Tienda, "IdTienda", "Nombre");
        ViewData["Roles"] = new SelectList(_context.Rol, "IdRol", "Descripcion");

        return Page();
    }

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Attach(Usuario).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ProductoExists(Usuario.IdUsuario))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return RedirectToPage("./Index");
    }

    private bool ProductoExists(int id)
    {
      return (_context.Usuario?.Any(e => e.IdUsuario == id)).GetValueOrDefault();
    }
}
