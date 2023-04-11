using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PartShop.Pages
{
    public class PagoRealizadoModel : PageModel
    {
        public async Task<IActionResult> OnGetAsync()
        {
            HttpContext.Response.Headers.Add("Refresh", "5;url=index");

            return Page();
        }
    }
}
