using PPD.WebApp.Domain.Entidades;

namespace PPD.WebApp.Infrastructure.Repository.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterPeloIdAsync(int peloId);
    }
}
