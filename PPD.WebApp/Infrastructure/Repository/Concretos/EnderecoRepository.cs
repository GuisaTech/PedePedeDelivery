using Microsoft.EntityFrameworkCore;
using PPD.Infrastructure.Data;
using PPD.WebApp.Domain.Entidades;
using PPD.WebApp.Infrastructure.Repository.Interfaces;

namespace PPD.WebApp.Infrastructure.Repository.Concretos
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly PedePedeContext _pedePedeContext;

        public EnderecoRepository(PedePedeContext pedePedeContext)
        {
            _pedePedeContext = pedePedeContext;
        }

        public async Task Adicionar(Endereco entidade)
        {
            _pedePedeContext.Enderecos.Add(entidade);
            await _pedePedeContext.SaveChangesAsync();
        }

        public async Task Atualizar(Endereco entidade)
        {
            _pedePedeContext.Update(entidade);
            await _pedePedeContext.SaveChangesAsync();
        }

        public async Task Remover(Endereco entidade)
        {
            entidade.AtualizarStatusRemovido(true);
            _pedePedeContext.Update(entidade);
            await _pedePedeContext.SaveChangesAsync();

        }

        public async Task<Endereco> ObterPeloIdAsync(int peloId)
        {
            return await _pedePedeContext.Enderecos.Where(x => x.Id == peloId && !x.Removido).FirstOrDefaultAsync();
        }
    }
}
