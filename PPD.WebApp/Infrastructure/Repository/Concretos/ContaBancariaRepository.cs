using Microsoft.EntityFrameworkCore;
using PPD.Infrastructure.Data;
using PPD.WebApp.Domain.Entidades;
using PPD.WebApp.Infrastructure.Repository.Interfaces;

namespace PPD.WebApp.Infrastructure.Repository.Concretos
{
    public class ContaBancariaRepository : IContaBancariaRepository
    {
        private readonly PedePedeContext _pedePedeContext;

        public ContaBancariaRepository(PedePedeContext pedePedeContext)
        {
            _pedePedeContext = pedePedeContext;
        }

        public async Task Adicionar(ContaBancaria entidade)
        {
            _pedePedeContext.ContasBancarias.Add(entidade);
            await _pedePedeContext.SaveChangesAsync();
        }

        public async Task Atualizar(ContaBancaria entidade)
        {
            _pedePedeContext.Update(entidade);
            await _pedePedeContext.SaveChangesAsync();
        }

        public async Task Remover(ContaBancaria entidade)
        {
            entidade.AtualizarStatusRemovido(true);
            _pedePedeContext.Update(entidade);
            await _pedePedeContext.SaveChangesAsync();

        }

        public async Task<ContaBancaria> ObterPeloIdAsync(int peloId)
        {
            return await _pedePedeContext.ContasBancarias.Where(x => x.Id == peloId && !x.Removido).FirstOrDefaultAsync();
        }
    }
}
