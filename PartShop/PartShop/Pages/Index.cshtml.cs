using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PartShop.Domain.Entities;
using PartShop.Domain.Repositories;

namespace PartShop.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ITiendaRepository _tiendaRepository;

        public List<Tienda> Tiendas { get; set; } = new();

        [BindProperty]
        public Tienda Tienda { get; set; } = new()
        {
            Activo = true
        };

        public IndexModel(ITiendaRepository tiendaRepository)
        {
            _tiendaRepository = tiendaRepository;
        }

        public void OnGet()
        {
            Tiendas = _tiendaRepository.GetAll().Result;
        }

        public void OnPostGuardar()
        {
            _tiendaRepository.Save(Tienda).Wait();

            OnGet();
        }

        public async Task OnPostEditarTienda(int idTienda)
        {
            Tienda = await _tiendaRepository.Find(tienda => tienda.IdTienda == idTienda);

            OnGet();
        }

        public async Task OnPostBorrarTienda(int idTienda)
        {
            await _tiendaRepository.Delete(tienda => tienda.IdTienda == idTienda);

            OnGet();
        }
    }
}