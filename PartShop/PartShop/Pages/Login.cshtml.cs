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
            var user = _context.Usuario.SingleOrDefaultAsync(u => u.Correo == email && u.Clave == password).Result;
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return Page();
            }

            // Store the user id in a cookie
            Response.Cookies.Append("UserId", user.IdUsuario.ToString(), new CookieOptions()
            {
                Expires = DateTimeOffset.UtcNow.AddDays(7),
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.Strict
            });

            return RedirectToPage("/Index");
        }

        public IActionResult OnGetLogout()
        {
            // Remove the user id cookie
            Response.Cookies.Delete("UserId");

            return RedirectToPage("/Index");
        }
    }
}
