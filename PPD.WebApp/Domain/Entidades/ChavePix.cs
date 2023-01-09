using PPD.WebApp.Domain.Enum;

namespace PPD.WebApp.Domain.Entidades
{
    public class ChavePix : Entidade
    {
        public int Id { get; private set; }
        public ETipoChavePix Tipo { get; private set;}
        public string Valor { get; private set; }
        public bool SouTitular { get; private set; }
        public ETitular Titular { get; private set; }

        public int UsuarioId { get; private set; }
        public Usuario Usuario { get; private set; }

        protected ChavePix() { }

        public ChavePix(ETipoChavePix tipo, string valor, bool souTitular, ETitular titular, int usuarioId)
        {
            Tipo = tipo;
            Valor = valor;
            SouTitular = souTitular;
            Titular = titular;
            DataRegistro = DateTime.UtcNow;
            Removido = false;
            UsuarioId = usuarioId;
        }
    }
}
