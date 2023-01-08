using PPD.WebApp.Domain.Entidades;

namespace PPD.WebApp.Infrastructure.Repository
{
    public interface IRepository<T> where T : Entidade
    {
        void Adicionar(T entidade);
        void Atualizar(T entidade);
        void Remover(T entidade);
    }
}
