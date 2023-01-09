using PPD.WebApp.Infrastructure.Repository.Interfaces;
using PPD.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using PPD.WebApp.Infrastructure.Repository.Concretos;

namespace PPD.WebApp.Infrastructure.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RepositoryDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PedePedeContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IArquivoRepository, ArquivoRepository>();
            services.AddScoped<IChavePixRepository, ChavePixRepository>();
            services.AddScoped<IContaBancariaRepository, ContaBancariaRepository>();
            services.AddScoped<IEmpresaRepository, EmpresaRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IRedeSocialRepository, RedeSocialRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
