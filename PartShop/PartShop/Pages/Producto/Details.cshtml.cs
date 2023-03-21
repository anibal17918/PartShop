using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace PartShop.Pages.Producto
{
    public class DetailsModel : PageModel
    {
        private readonly PartShop.Infrastructure.PartShopDbContext _context;

        public DetailsModel(PartShop.Infrastructure.PartShopDbContext context)
        {
            _context = context;
        }

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
    }
}
