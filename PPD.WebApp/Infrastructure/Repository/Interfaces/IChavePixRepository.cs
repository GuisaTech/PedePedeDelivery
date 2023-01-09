using PPD.WebApp.Domain.Entidades;

namespace PPD.WebApp.Infrastructure.Repository.Interfaces
{
    public interface IChavePixRepository : IRepository<ChavePix>
    {
        Task<ChavePix> ObterPeloIdAsync(int peloId);

    }
}
