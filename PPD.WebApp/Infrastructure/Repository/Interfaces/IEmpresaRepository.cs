using PPD.WebApp.Domain.Entidades;

namespace PPD.WebApp.Infrastructure.Repository.Interfaces
{
    public interface IEmpresaRepository : IRepository<Empresa>
    {
        Task<Empresa> ObterPeloIdAsync(int id);
    }
}
