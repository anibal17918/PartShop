using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PartShop.Domain.Entities;
using System;

namespace PartShop.Pages.Login
{
    public class IndexModel : PageModel
    {
        private readonly PartShop.Infrastructure.PartShopDbContext _context;

        public IndexModel(PartShop.Infrastructure.PartShopDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var email = Request.Form["correo"].ToString();
            var password = Request.Form["clave"].ToString();

            // Code to validate the email and password and authenticate the user
            var user = _context.Usuario.SingleOrDefaultAsync(u => u.Correo == email && u.Clave == password && u.Activo).Result;
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return Page();
            }

            HttpContext.Session.SetString("UserId", user.IdUsuario.ToString());
            HttpContext.Session.SetString("RolId", user.IdRol.ToString() ?? string.Empty);

            return RedirectToPage("/Index");
        }
    }
}
