using Microsoft.EntityFrameworkCore;
using PPD.Infrastructure.Data;
using PPD.WebApp.Domain.Entidades;
using PPD.WebApp.Infrastructure.Repository.Interfaces;

namespace PPD.WebApp.Infrastructure.Repository.Concretos
{
    public class RedeSocialRepository: IRedeSocialRepository
    {
        private readonly PedePedeContext _pedePedeContext;

        public RedeSocialRepository(PedePedeContext pedePedeContext)
        {
            _pedePedeContext = pedePedeContext;
        }

        public async Task Adicionar(RedeSocial entidade)
        {
            _pedePedeContext.RedesSociais.Add(entidade);
            await _pedePedeContext.SaveChangesAsync();
        }

        public async Task Atualizar(RedeSocial entidade)
        {
            _pedePedeContext.Update(entidade);
            await _pedePedeContext.SaveChangesAsync();
        }

        public async Task Remover(RedeSocial entidade)
        {
            entidade.AtualizarStatusRemovido(true);
            _pedePedeContext.Update(entidade);
            await _pedePedeContext.SaveChangesAsync();

        }

        public async Task<RedeSocial> ObterPeloIdAsync(int peloId)
        {
            return await _pedePedeContext.RedesSociais.Where(x => x.Id == peloId && !x.Removido).FirstOrDefaultAsync();
        }
    }
}
