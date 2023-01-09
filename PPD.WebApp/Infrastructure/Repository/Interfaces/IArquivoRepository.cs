using PPD.WebApp.Domain.Entidades;

namespace PPD.WebApp.Infrastructure.Repository.Interfaces
{
    public interface IArquivoRepository : IRepository<Arquivo>
    {
        Task<Arquivo> ObterPeloIdAsync(int peloId);

    }
}
