using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PartShop.Pages.Producto
{
    public class CreateModel : PageModel
    {
        private readonly PartShop.Infrastructure.PartShopDbContext _context;

        public CreateModel(PartShop.Infrastructure.PartShopDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["IdCategoria"] = new SelectList(_context.Categoria, "IdCategoria", "IdCategoria");
            return Page();
        }

        [BindProperty]
        public Domain.Entities.Producto Producto { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Producto == null || Producto == null)
            {
                return Page();
            }

            _context.Producto.Add(Producto);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
