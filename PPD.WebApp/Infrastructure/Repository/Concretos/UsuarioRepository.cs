using Microsoft.EntityFrameworkCore;
using PPD.Infrastructure.Data;
using PPD.WebApp.Domain.Entidades;
using PPD.WebApp.Infrastructure.Repository.Interfaces;

namespace PPD.WebApp.Infrastructure.Repository.Concretos
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly PedePedeContext _pedePedeContext;

        public UsuarioRepository(PedePedeContext pedePedeContext)
        {
            _pedePedeContext = pedePedeContext;
        }

        public async Task Adicionar(Usuario entidade)
        {
            _pedePedeContext.Usuarios.Add(entidade);
            await _pedePedeContext.SaveChangesAsync();
        }

        public async Task Atualizar(Usuario entidade)
        {
            _pedePedeContext.Update(entidade);
            await _pedePedeContext.SaveChangesAsync();
        }

        public async Task Remover(Usuario entidade)
        {
            entidade.AtualizarStatusRemovido(true);
            _pedePedeContext.Update(entidade);
            await _pedePedeContext.SaveChangesAsync();

        }

        public async Task<Usuario> ObterPeloIdAsync(int peloId)
        {
            return await _pedePedeContext.Usuarios.Where(x => x.Id == peloId && !x.Removido).FirstOrDefaultAsync();
        }
    }
}
