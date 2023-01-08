using PPD.WebApp.Infrastructure.Repository.Interfaces;
using PPD.WebApp.Infrastructure.Repository;
using PPD.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace PPD.WebApp.Infrastructure.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RepositoryDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PedePedeContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
