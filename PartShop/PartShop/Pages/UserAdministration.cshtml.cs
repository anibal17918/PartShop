using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PartShop.Domain.Entities;
using PartShop.Domain.Repositories;

namespace PartShop.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public List<Usuario> Usuarios { get; set; } = new();

        [BindProperty]
        public Usuario Usuario { get; set; } = new()
        {
            Activo = true
        };

        public IndexModel(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void OnGet()
        {
            Usuarios = _usuarioRepository.GetAll().Result;
        }

        public void OnPostGuardar()
        {
            _usuarioRepository.Save(Usuario).Wait();

            OnGet();
        }

        public async Task OnPostEditar(int idUsuario)
        {
            Usuario = await _usuarioRepository.Find(usuario => usuario.IdUsuario == idUsuario);

            OnGet();
        }

        public async Task OnPostBorrar(int idUsuario)
        {
            await _usuarioRepository.Delete(usuario => usuario.IdUsuario == idUsuario);

            OnGet();
        }
    }
}