using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace PartShop.Pages.Producto
{
    public class DeleteModel : PageModel
    {
        private readonly PartShop.Infrastructure.PartShopDbContext _context;

        public DeleteModel(PartShop.Infrastructure.PartShopDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Domain.Entities.Producto Producto { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Producto == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto.FirstOrDefaultAsync(m => m.IdProducto == id);

            if (producto == null)
            {
                return NotFound();
            }
            else 
            {
                Producto = producto;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Producto == null)
            {
                return NotFound();
            }
            var producto = await _context.Producto.FindAsync(id);

            if (producto != null)
            {
                Producto = producto;
                _context.Producto.Remove(Producto);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
