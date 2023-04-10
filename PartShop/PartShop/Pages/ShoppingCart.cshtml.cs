using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PartShop.Domain.Entities;

namespace PartShop.Pages;

public class ShoppingCartModel : PageModel
{
    private readonly PartShop.Infrastructure.PartShopDbContext _context;

    public ShoppingCartModel(PartShop.Infrastructure.PartShopDbContext context)
    {
        _context = context;
    }

    public Venta Venta { get; set; } = default!;

    [BindProperty]
    public int IdVenta { get; set; }

    public async Task OnGetAsync()
    {
        if (_context.Venta != null)
        {
            var _ = int.TryParse(HttpContext.Session.GetString("UserId"), out var idUsuario);

            Venta = await _context.Venta.Where(v => v.IdUsuario == idUsuario && v.Activo)
                .Include(v => v.DetalleVenta)
                .ThenInclude(dv => dv.IdProductoNavigation)
                .FirstOrDefaultAsync() ?? new Venta();

            IdVenta = Venta.IdVenta;
        }
    }

    public async Task<IActionResult> OnPostAsync()
    {
        var venta = await _context.Venta.FirstOrDefaultAsync(v => v.IdVenta == IdVenta);

        venta.Activo = false;

        _context.Venta.Update(venta);

        await _context.SaveChangesAsync();

        return RedirectToPage("./PagoRealizado");
    }
}