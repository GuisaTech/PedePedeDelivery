using PPD.WebApp.Domain.Enum;

namespace PPD.WebApp.Domain.Entidades
{
    public class ChavePix
    {
        public int Id { get; private set; }
        public TipoChavePix Tipo { get; private set;}
        public string Valor { get; private set; }
        public bool SouTitular { get; private set; }
        public Titular Titular { get; private set; }

        public DateTime DataRegistro { get; private set; }
        public bool Removido { get; private set; }

        public int UsuarioId { get; private set; }
        public Usuario Usuario { get; private set; }

        protected ChavePix() { }

        public ChavePix(TipoChavePix tipo, string valor, bool souTitular, Titular titular, int usuarioId)
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
