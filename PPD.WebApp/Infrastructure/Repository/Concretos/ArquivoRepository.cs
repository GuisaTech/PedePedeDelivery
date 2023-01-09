using Microsoft.EntityFrameworkCore;
using PPD.Infrastructure.Data;
using PPD.WebApp.Domain.Entidades;
using PPD.WebApp.Infrastructure.Repository.Interfaces;

namespace PPD.WebApp.Infrastructure.Repository.Concretos
{
    public class ArquivoRepository : IArquivoRepository
    {
        private readonly PedePedeContext _pedePedeContext;

        public ArquivoRepository(PedePedeContext pedePedeContext)
        {
            _pedePedeContext = pedePedeContext;
        }

        public async Task Adicionar(Arquivo entidade)
        {
            _pedePedeContext.Arquivos.Add(entidade);
            await _pedePedeContext.SaveChangesAsync();
        }

        public async Task Atualizar(Arquivo entidade)
        {
            _pedePedeContext.Update(entidade);
            await _pedePedeContext.SaveChangesAsync();
        }

        public async Task Remover(Arquivo entidade)
        {
            entidade.AtualizarStatusRemovido(true);
            _pedePedeContext.Update(entidade);
            await _pedePedeContext.SaveChangesAsync();

        }

        public async Task<Arquivo> ObterPeloIdAsync(int peloId)
        {
            return await _pedePedeContext.Arquivos.Where(x => x.Id == peloId && !x.Removido).FirstOrDefaultAsync();
        }
    }
}
