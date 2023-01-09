using PPD.WebApp.Domain.Entidades;

namespace PPD.WebApp.Infrastructure.Repository
{
    public interface IRepository<T> where T : Entidade
    {
        Task Adicionar(T entidade);
        Task Atualizar(T entidade);
        Task Remover(T entidade);
    }
}
