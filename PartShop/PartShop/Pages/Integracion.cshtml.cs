using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PartShop.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PartShop.Pages
{
    public class IntegracionModel : PageModel
    {
        public List<Vehiculo> Vehiculos { get; set; }

        [BindProperty]
        public int Id { get; set; }

        [BindProperty]
        public string Comentario { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            try
            {
                Vehiculos = await Vehiculo.ObtenerTodosLosVehiculos();
                return Page();
            }
            catch (Exception ex)
            {
                return BadRequest("Error al obtener los vehículos de la API: " + ex.Message);
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                await Vehiculo.AgregarComentario(Id, Comentario);
                return RedirectToPage("./Integracion");
            }
            catch (Exception ex)
            {
                return BadRequest("Error al agregar el comentario: " + ex.Message);
            }
        }


    }
}
