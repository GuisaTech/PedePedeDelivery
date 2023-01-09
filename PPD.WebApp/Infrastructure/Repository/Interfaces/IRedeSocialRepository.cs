using PPD.WebApp.Domain.Entidades;

namespace PPD.WebApp.Infrastructure.Repository.Interfaces
{
    public interface IRedeSocialRepository : IRepository<RedeSocial>
    {
        Task<RedeSocial> ObterPeloIdAsync(int peloId);
    }
}
