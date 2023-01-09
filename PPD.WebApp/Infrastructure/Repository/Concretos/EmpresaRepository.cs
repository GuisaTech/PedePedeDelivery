using Microsoft.EntityFrameworkCore;
using PPD.Infrastructure.Data;
using PPD.WebApp.Domain.Entidades;
using PPD.WebApp.Infrastructure.Repository.Interfaces;

namespace PPD.WebApp.Infrastructure.Repository.Concretos
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly PedePedeContext _pedePedeContext;

        public EmpresaRepository(PedePedeContext pedePedeContext)
        {
            _pedePedeContext = pedePedeContext;
        }

        public async Task Adicionar(Empresa entidade)
        {
            _pedePedeContext.Empresas.Add(entidade);
            await _pedePedeContext.SaveChangesAsync();
        }

        public async Task Atualizar(Empresa entidade)
        {
            _pedePedeContext.Update(entidade);
            await _pedePedeContext.SaveChangesAsync();
        }

        public async Task Remover(Empresa entidade)
        {
            entidade.AtualizarStatusRemovido(true);
            _pedePedeContext.Update(entidade);
            await _pedePedeContext.SaveChangesAsync();

        }

        public async Task<Empresa> ObterPeloIdAsync(int peloId)
        {
            return await _pedePedeContext.Empresas.Where(x => x.Id == peloId && !x.Removido).FirstOrDefaultAsync();
        }
    }
}
