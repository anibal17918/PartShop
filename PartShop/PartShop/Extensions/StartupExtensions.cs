using PartShop.Domain.Repositories;
using PartShop.Infrastructure.Repositories;

namespace PartShop.Extensions
{
    public static class StartupExtensions
    {
        public static void AddPartShopServices(this IServiceCollection services)
        {
            services.AddScoped<ITiendaRepository, TiendaRepository>();
        }
    }
}
