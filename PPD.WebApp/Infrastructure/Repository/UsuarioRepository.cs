using Microsoft.EntityFrameworkCore;
using PPD.Infrastructure.Data;
using PPD.WebApp.Domain.Entidades;
using PPD.WebApp.Infrastructure.Repository.Interfaces;

namespace PPD.WebApp.Infrastructure.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly PedePedeContext _pedePedeContext;

        public UsuarioRepository(PedePedeContext pedePedeContext)
        {
            _pedePedeContext = pedePedeContext;
        }

        public void Adicionar(Usuario entidade)
        {
            _pedePedeContext.Usuarios.Add(entidade);
            _pedePedeContext.SaveChanges();
        }

        public void Atualizar(Usuario entidade)
        {
            _pedePedeContext.Update(entidade);
            _pedePedeContext.SaveChanges();
        }

        public void Remover(Usuario entidade)
        {
            entidade.AtualizarStatusRemovido(true);
            _pedePedeContext.Update(entidade);
            _pedePedeContext.SaveChanges();
        }

        public async Task<Usuario> ObterPeloIdAsync(int peloId)
        {
            return await _pedePedeContext.Usuarios.Where(x => x.Id == peloId && !x.Removido).FirstOrDefaultAsync();
        }
    }
}
