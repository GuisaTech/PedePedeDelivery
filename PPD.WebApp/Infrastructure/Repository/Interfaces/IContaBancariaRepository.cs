using PPD.WebApp.Domain.Entidades;

namespace PPD.WebApp.Infrastructure.Repository.Interfaces
{
    public interface IContaBancariaRepository : IRepository<ContaBancaria>
    {
        Task<ContaBancaria> ObterPeloIdAsync(int peloId);
    }
}
