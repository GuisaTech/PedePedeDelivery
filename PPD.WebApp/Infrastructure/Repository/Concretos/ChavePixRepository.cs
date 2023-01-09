using Microsoft.EntityFrameworkCore;
using PPD.Infrastructure.Data;
using PPD.WebApp.Domain.Entidades;
using PPD.WebApp.Infrastructure.Repository.Interfaces;

namespace PPD.WebApp.Infrastructure.Repository.Concretos
{
    public class ChavePixRepository : IChavePixRepository
    {
        private readonly PedePedeContext _pedePedeContext;

        public ChavePixRepository(PedePedeContext pedePedeContext)
        {
            _pedePedeContext = pedePedeContext;
        }

        public async Task Adicionar(ChavePix entidade)
        {
            _pedePedeContext.ChavesPix.Add(entidade);
            await _pedePedeContext.SaveChangesAsync();
        }

        public async Task Atualizar(ChavePix entidade)
        {
            _pedePedeContext.Update(entidade);
            await _pedePedeContext.SaveChangesAsync();
        }

        public async Task Remover(ChavePix entidade)
        {
            entidade.AtualizarStatusRemovido(true);
            _pedePedeContext.Update(entidade);
            await _pedePedeContext.SaveChangesAsync();

        }

        public async Task<ChavePix> ObterPeloIdAsync(int peloId)
        {
            return await _pedePedeContext.ChavesPix.Where(x => x.Id == peloId && !x.Removido).FirstOrDefaultAsync();
        }
    }
}
