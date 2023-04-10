using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace PartShop.Pages.Producto
{
    public class EditModel : PageModel
    {
        private readonly PartShop.Infrastructure.PartShopDbContext _context;

        public EditModel(PartShop.Infrastructure.PartShopDbContext context)
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

            var producto =  await _context.Producto.FirstOrDefaultAsync(m => m.IdProducto == id);
            if (producto == null)
            {
                return NotFound();
            }

            Producto = producto;

            ViewData["IdCategoria"] = new SelectList(_context.Categoria.ToList(), "IdCategoria", "Descripcion");

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

            _context.Attach(Producto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductoExists(Producto.IdProducto))
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
          return (_context.Producto?.Any(e => e.IdProducto == id)).GetValueOrDefault();
        }
    }
}
