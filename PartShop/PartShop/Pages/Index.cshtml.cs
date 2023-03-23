using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PartShop.Domain.Entities;

namespace PartShop.Pages;

public class IndexModel : PageModel
{
    private readonly PartShop.Infrastructure.PartShopDbContext _context;

    public IndexModel(PartShop.Infrastructure.PartShopDbContext context)
    {
        _context = context;
    }

    public IList<Domain.Entities.Producto> Producto { get; set; } = default!;

    public async Task OnGetAsync()
    {
        if (_context.Producto != null)
        {
            Producto = await _context.Producto.ToListAsync();
        }
    }

    public async Task OnPostAsync()
    {
        var searchString = Request.Form["searchString"];
        if (!string.IsNullOrEmpty(searchString))
        {
            Producto = await _context.Producto
                .Where(p => p.Nombre.Contains(searchString)).ToListAsync();
        }
        else
        {
            ModelState.AddModelError("searchString", "Please enter a search term.");
        }
    }

}
