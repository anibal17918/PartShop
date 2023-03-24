using Microsoft.AspNetCore.Mvc;
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
    
    public async Task<IActionResult> OnGetAsync(int? idProducto)
    {
        if (_context.Producto != null)
        {
            Producto = await _context.Producto.ToListAsync();

            if (idProducto is not null)
            {
                var producto = await _context.Producto.FindAsync(idProducto);

                var _ = int.TryParse(HttpContext.Session.GetString("UserId"), out var idUsuario);

                var venta = await _context.Venta.FirstOrDefaultAsync(v => v.IdUsuario == idUsuario && v.Activo);

                if (venta is null)
                {
                    venta = new Venta
                    {
                        IdUsuario = idUsuario,
                        TotalCosto = producto.ValorCodigo
                    };

                    var newVenta = await _context.Venta.AddAsync(venta);

                    await _context.SaveChangesAsync();

                    venta.IdVenta = newVenta.Entity.IdVenta;
                }
                else
                {
                    venta.TotalCosto += producto.ValorCodigo;

                    _context.Venta.Update(venta);

                    await _context.SaveChangesAsync();
                }

                var detalleVenta = new DetalleVenta
                {
                    IdVenta = venta.IdVenta,
                    IdProducto = idProducto,
                    Cantidad = 1,
                    PrecioUnidad = producto.ValorCodigo,
                    ImporteTotal = producto.ValorCodigo
                };

                await _context.DetalleVenta.AddAsync(detalleVenta);

                await _context.SaveChangesAsync();
            }
        }

        return Page();
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

    public IActionResult OnGetLogout()
    {
        HttpContext.Session.Clear();

        return RedirectToPage("/Index");
    }
}
