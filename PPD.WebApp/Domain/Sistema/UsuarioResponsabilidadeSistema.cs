using PPD.WebApp.Domain.Entidades;

namespace PPD.WebApp.Domain.Sistema
{
    public class UsuarioResponsabilidadeSistema
    {
        public int Id { get; private set; }
        public bool AtualizarDadosPessoais { get; private set; }
        public bool AtualizarDadosEmpresa { get; private set; }
        public bool AtualizarContaBancaria { get; private set; }
        public bool AtualizarChavePix { get; private set; }
        public bool AtualizarMinhaEmpresa { get; private set; }
        public bool AtualizarRedesSociais { get; private set; }
        public bool AtualizarArquivos { get; private set; }
        public int UsuarioId { get; private set; }
        public Usuario Usuario { get; private set; }

        public UsuarioResponsabilidadeSistema(
            bool atualizarDadosPessoais, bool atualizarDadosEmpresa,
            bool atualizarContaBancaria, bool atualizarChavePix, bool atualizarMinhaEmpresa,
            bool atualizarRedesSociais, bool atualizarArquivos, int usuarioId, Usuario usuario)
        {
            AtualizarDadosPessoais = atualizarDadosPessoais;
            AtualizarDadosEmpresa = atualizarDadosEmpresa;
            AtualizarContaBancaria = atualizarContaBancaria;
            AtualizarChavePix = atualizarChavePix;
            AtualizarMinhaEmpresa = atualizarMinhaEmpresa;
            AtualizarRedesSociais = atualizarRedesSociais;
            AtualizarArquivos = atualizarArquivos;
            UsuarioId = usuarioId;
            Usuario = usuario;
        }
    }
}
