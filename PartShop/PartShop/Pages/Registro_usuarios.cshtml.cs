using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartShop.Domain.Entities;
using System.Threading.Tasks;

namespace PartShop.Pages.Registro_usuarios
{
    public class IndexModel : PageModel
    {
        private readonly PartShop.Infrastructure.PartShopDbContext _context;

        public IndexModel(PartShop.Infrastructure.PartShopDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Usuario Usuario { get; set; }

        public IList<Domain.Entities.Usuario> Usuarios { get; set; } = default!;
        public async Task OnGetAsync()
        {
            if (_context.Usuario != null)
            {
                Usuarios = await _context.Usuario
                .Include(p => p.IdRolNavigation).ToListAsync();
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var usuario = new Usuario
            {
                Nombres = Usuario.Nombres,
                Apellidos = Usuario.Apellidos,
                Correo = Usuario.Correo,
                Usuario1 = Usuario.Usuario1,
                Clave = Usuario.Clave,
                IdTienda = Usuario.IdTienda,
                IdRol = Usuario.IdRol
            };

            _context.Usuario.Add(usuario);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }

}