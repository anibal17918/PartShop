using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PartShop.Pages.UserAdministration;

public class CreateUserModel : PageModel
{
    private readonly PartShop.Infrastructure.PartShopDbContext _context;

    public CreateUserModel(PartShop.Infrastructure.PartShopDbContext context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
    ViewData["IdCategoria"] = new SelectList(_context.Categoria, "IdCategoria", "IdCategoria");
        return Page();
    }

    [BindProperty]
    public Domain.Entities.Usuario Usuario { get; set; } = default!;
    

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid || _context.Usuario == null || Usuario == null)
        {
            return Page();
        }

        _context.Usuario.Add(Usuario);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
